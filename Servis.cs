using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Runtime.InteropServices;          //new modul pro Marshal
using System.Windows.Forms;                    //new modul pro Kvuli GetMainForm

using System.Timers;
namespace Car_unit_simulator
{
    class Servis
    {
        
        data_t Simulation_data_GPS = new data_t();
        SECOND_data_t Simulation_data_car = new SECOND_data_t();
        Simulator iSimulator = null;
        SerialLine UART = null;

        private static System.Timers.Timer aTimer;
        private byte pos = 0;
        //***********************************************artificial data*******************************************************//
        public byte[] data_get;                //BUFFER S ODPOVEDI

        private double[] latitude = { 49.3444081, 49.3415736, 49.3398083, 49.3392736, 49.3393294, 49.3398783, 49.3397350, 49.3399553, 49.3402733, 49.3412519, 49.3416225, 49.3424542, 49.3436078, 49.3445722, 49.3456767, 49.3461381, 49.3470886 };
        private double[] longitude = { 16.7355522, 16.7379125, 16.7393825, 16.7412278, 16.7437867, 16.7455033, 16.7468231, 16.7480192, 16.7484564, 16.7503769, 16.7523403, 16.7535633, 16.7550011, 16.7565889, 16.7589922, 16.7597969, 16.7609986 };
        private UInt16[] temp = { 79, 80, 82, 88, 90, 95, 10, 102, 11, 112, 113, 119, 125, 123, 129, 130, 134 };
        private UInt16[] voltage = { 120, 120, 121, 121, 119, 120, 123, 125, 128, 124, 123, 123, 124, 125, 125, 125, 124 };

        const byte key = 0x20;
        const byte RF_door = 0x01;             //right front door   
        const byte LF_door = 0x02;             //left front door
        const byte RB_door = 0x04;             //right rear door
        const byte LB_door = 0x08;             //left rear door

        public struct data_t
        {

            public double latitude;            //zemepisna sirka
            public double longitude;           //zemepisna delka 
            public UInt16 speed;               //rychlost [km x 10]
            public UInt16 height;              //height GPS [m]
            public byte hod;                   //Hodiny
            public byte min;                   //minuty
            public byte sec;                   //sekundy
            public byte month;                 //mesic
            public byte day;                   //den
            public byte kvalita;               //kvalita pozice (0 invalid, 1 GPS, 2 DGPS)
            public byte satelity;              //pocet satelitu
            public UInt16 azimut;              //azimut
            public byte status;                //status
        }

        public struct SECOND_data_t
        {
            public UInt16 Act_speed;           //aktualni rychlost
            public UInt16 Av_speed;            //prumera rychlost

            public UInt16 trip;                //najete km od zapnuti klicku
            public UInt16 time_trip;           //cas od zapnuti klicku 
            public UInt32 total_km;            //celkovy pocet najetych km

            public UInt16 Fuel;                //Spotrebovane palivo
            public UInt16 Av_Consuption;       //prumerna spotreba
            public UInt16 Act_Consuption;      //actualni spotreba

            public UInt16 Temp_IN;             //Vnitrni teplota
            public UInt16 Temp_Out;            //Venkovni teplota
            public UInt16 Temp_water;          //Teploty chaldící kapaliny

            public UInt16 Voltage;             //Napeti baterie

            public byte Door;
            public byte Info;
        }
        
        //***************************************************************************************************************//
        public Servis(Simulator aSimulator, SerialLine serial)
        {
            //Inicializace
            iSimulator = aSimulator;
            UART = serial;
            Simulation_data_car.trip = 0;
            Simulation_data_car.Fuel = 370;
        }
        SerialLine GetMainForm()
        {
            foreach (SerialLine form in Application.OpenForms)
                if (form is SerialLine)
                    return (SerialLine)form;
            return null;
        }
        public void Set_fuel()
        {
            Simulation_data_car.Fuel = 370;
        }
        /***********************************Timer*******************************************/
        public void SetTimer()
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(3000);                                             //NASTAV DOBU PRERUSENI TIMERU
            // Hook up the Elapsed event for the timer.                                         
            aTimer.Elapsed += OnTimedEvent;                                                     //NASTAVENI FUNKCE KTERA SE MA ZAVOLAT PRI PRERUSENI
            aTimer.AutoReset = true;                                                            //POVOLENI AUTO RESETU
            aTimer.Enabled = true;                                                              //POVOLENI TIMERU
        }
        /***********************************************************************************/
        //VYBERE FUNKCI KTERA ZAJISTUJE NAPLNENI STRUKTURY PRO ODPOVED NA ZAKLADE PRIJATEHO COMANNDU
        public void povel(byte[] command)
        {
            switch (command[2])                                                                 
            {
                case 0x01:
                          OK();
                          break;
                case 0x03:
                          Time();
                          break;
                case 0x06:
                          Version();
                          break;
                case 0x40:
                          GPS();
                          break;
                case 0x80:
                          car_info();
                          break;
                case 0x81:
                          Set_output(command[3], command[4]);
                         break;
                default:
                        Notfound();
                        break;
            }
        }
        /***********************************************************************************/
        //Generovani umelych dat slouzi pouze zkouseni, nejsou generovany vsechny hodnota
        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Random random_number = new Random();
            if (Simulation_data_car.Fuel > 6)
            {
                pos++;
                if (pos == latitude.Length)
                {
                    pos = 0;
                }

                Simulation_data_GPS.latitude = latitude[pos];
                Simulation_data_GPS.longitude = longitude[pos];
                Simulation_data_GPS.speed = (byte)random_number.Next(500, 550);
                Simulation_data_GPS.status = (byte)random_number.Next(0, 2);
                Simulation_data_GPS.height = (UInt16)(GetRandomNumber(545, 555));
                Simulation_data_GPS.satelity = (byte)random_number.Next(8, 15);
                Simulation_data_GPS.kvalita = (byte)random_number.Next(0, 2);
                Simulation_data_car.trip++;
                Simulation_data_car.total_km++;
                Simulation_data_car.Fuel -= 6; //
            }
            else
            {
                Simulation_data_GPS.speed = 0;
            }
                Simulation_data_car.Temp_IN = (byte)random_number.Next(18, 22);
            Simulation_data_car.Act_speed = Simulation_data_GPS.speed;
            Simulation_data_car.Temp_Out = temp[pos];
            Simulation_data_car.Voltage = voltage[pos];
            /*******************************************************************************/
            iSimulator.Update("temp_in", Simulation_data_car.Temp_IN.ToString());
            iSimulator.Update("temp_out", Simulation_data_car.Temp_Out.ToString());
            iSimulator.Update("fuel", Simulation_data_car.Fuel.ToString());
            iSimulator.Update("trip", Simulation_data_car.trip.ToString());
            iSimulator.Update("total", Simulation_data_car.total_km.ToString());
            iSimulator.Update("voltage", Simulation_data_car.Voltage.ToString());

            iSimulator.Update("longtitude", Simulation_data_GPS.longitude.ToString());
            iSimulator.Update("lattitude", Simulation_data_GPS.latitude.ToString());
            iSimulator.Update("speed", Simulation_data_GPS.speed.ToString());
            iSimulator.Update("height", Simulation_data_GPS.height.ToString());
            iSimulator.Update("satelity", Simulation_data_GPS.satelity.ToString());
            iSimulator.Update("quality", Simulation_data_GPS.kvalita.ToString());
        }
        /***********************************************************************************/
        //Jednotlive povely
        /***********************************************************************************/
        private void OK()
        {
            string version = "OK";
            data_get = Encoding.ASCII.GetBytes(version);
        }
        /***********************************************************************************/
        private void Time()
        {
            data_get = Encoding.ASCII.GetBytes(DateTime.Now.ToString("yyyyMMDDHHmmss"));  //Real system time
        }
        /***********************************************************************************/
        private void Version()
        {
            string version = " Simulator_1.0 ";
            data_get= Encoding.ASCII.GetBytes(version);
        }
        /***********************************************************************************/
        private void GPS()
        {
            data_get = getBytes(Simulation_data_GPS);
        }
        /***********************************************************************************/
        private void car_info()
        {
            data_get = getBytes(Simulation_data_car);
        }
        /***********************************************************************************/
        private void Set_output(byte vstup,byte state)
        {
            switch (vstup)
            {
                case 1:
                    if(state == 1)
                        iSimulator.Update("Output1", "1");
                    else
                        iSimulator.Update("Output1", "0");
                    break;
                case 2:
                    if (state == 1)
                        iSimulator.Update("Output2", "1");
                    else
                        iSimulator.Update("Output2", "0");
                    break;
                case 3:
                    if (state == 1)
                        iSimulator.Update("Output3", "1");
                    else
                        iSimulator.Update("Output3", "0");
                    break;
                default:

                    break;
            }
        }

        /***********************************************************************************/
        private void Notfound()
        {
            UART.error_transfer = (byte)SerialLine.Error.NFoundCom;
        }
        /***********************************************************************************/
        //funkce vrati pole, kde jsou rozlozeny data ze struktury po jednotlivych bytech
        byte[] getBytes<T>(T str) 
        {
            int size = Marshal.SizeOf(str);
            byte[] arr = new byte[size];

            IntPtr ptr = Marshal.AllocHGlobal(size);
            Marshal.StructureToPtr(str, ptr, true);
            Marshal.Copy(ptr, arr, 0, size);
            Marshal.FreeHGlobal(ptr);
            return arr;
        }
        /***********************************************************************************/
        // Vrati nahodne cislo v danem v rozsahu definovanem paramatry min a max
        private double GetRandomNumber(double min, double max)
        {
            Random random_number = new Random();
            return random_number.NextDouble() * (max - min) + min;
        }
    }

}
