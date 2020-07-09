using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.IO.Ports;//Knihovna pridana

namespace Car_unit_simulator
{
    class SerialLine : SerialPort
    {
        public Servis Servis_modul = null;

        /*************************************ERRORS transfer***********************************/
        public byte error_transfer = 0;                //bude ulozena hodnota chyby typ chyby viz nize
        byte ACK = 0x06;                        //ACK potvrzeni prijmu
        byte NACK = 0x15;                        //bude ulozena hodnota chyby typ chyby viz nize

        public enum Error
        {
            INParam = 0x01,                     // invalid parameter
            ECRC = 0x02,                        // error crc
            NoVData = 0x03,                     // no valid data
            NFoundCom = 0x04,                   // command not found
        }
        /**************************************************************************************/

        private byte[] indata;                      //string prijata data
        SerialPort mySerialPort = new SerialPort(); //Instance serial port
        private byte[] _Buffer;                     
        private bool stav = false;

        public SerialLine(Simulator aSimulator)
        {
            Servis_modul = new Servis(aSimulator,this);
            Servis_modul.SetTimer();
        }

        Simulator GetMainForm()
        {
            foreach (Simulator form in Application.OpenForms)
                if (form is Simulator)
                    return (Simulator)form;
            return null;
        }

        // Nastaveni parametru pro seriovy prenos
        public void Serial_setting(string portname,
                                   Int32 baud,
                                   string parita,
                                   int databits,
                                   string stopbit
                                  )
        {
            mySerialPort.PortName = portname;
            mySerialPort.BaudRate = baud;
            mySerialPort.DataBits = databits;
            switch (parita)
            {
                case "None":mySerialPort.Parity = Parity.None;
                            break;
                case "Mark":mySerialPort.Parity = Parity.Mark;
                            break;
                case "Even":mySerialPort.Parity = Parity.Even;
                            break;
                case "Odd":mySerialPort.Parity = Parity.Odd;
                           break;
                case "Space":mySerialPort.Parity = Parity.Space;
                            break;
            }

            switch (stopbit)
            {
                case "0":
                    mySerialPort.StopBits = StopBits.None;
                    break;
                case "1":
                    mySerialPort.StopBits = StopBits.One;
                    break;
                case "1.5":
                    mySerialPort.StopBits = StopBits.OnePointFive;
                    break;
                case "2":
                    mySerialPort.StopBits = StopBits.Two;
                    break;
            }
            mySerialPort.Handshake = Handshake.None;
            mySerialPort.RtsEnable = true;
            mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }

        // Prijem dat
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {

            SerialPort sp = (SerialPort)sender;                
            byte[] buf = new byte[sp.BytesToRead];
            sp.Read(buf, 0, buf.Length);
            indata = buf;                                                           //Ulozeni buf do globalniho bufferu indata 
            Simulator.Self.Invoke(new Action(() =>                                  //Invoke aby bylo moyne pristoupit fo hlavniho formulare
            {
                Simulator.Self.list("Request");                                     //Vyvola udalost pro zobrazeni dat do Listboxu
            }));

            if (CRC_check(buf))                                                     //Kontrola CRC
            {
                Servis_modul.povel(buf);                                            //Prijata data poslana do servis                                      
                puts(Servis_modul.data_get);                                        //mySerialPort.Write(Servis_modul.data_get,0,30);
            }
            else
            {
                error_transfer = (byte)Error.NFoundCom;                             //NASTAV CISLO ODPOVIDAJICI CHYBY
                puts(null);                                                             
            }
        }
        // sestavovani bufferu pro odeslani
        public void puts(byte[] buffer)
        {
            try
            {
                Servis_modul.data_get = null;
                if (buffer == null)
                    buffer = new byte[0];

                _Buffer = new byte[buffer.Length + 7];                              //delka bufferu =  delka dat + ACK/NACK + chyba+ data  + CRC
                _Buffer[0] = (byte)(buffer.Length + 2);                             //Ulozeni delky

                Array.Copy(buffer, 0, _Buffer, 3, buffer.Length);                   //vlozeni bufferu s daty fo vysilaciho bufferu
                if (error_transfer == 0)                                            //Pokud nenastala chyba pri prenosu
                {
                    _Buffer[2] = ACK;                                               //NASTAV POTVRZENI PRIJMU 
                    if (buffer.Length > 0)                                          //VYNULUJ INFORMACI O CHYBE
                        _Buffer[3] = 1;                                             //VYNULUJ INFORMACI O CHYBE
                    else
                    _Buffer[3] = 0;                                                 //VYNULUJ INFORMACI O CHYBE 
                }
                else
                {
                    _Buffer[2] = NACK;                                              //NASTAV VLAJKU CHYBA PRIJMU
                    _Buffer[3] = error_transfer;                                    //IFORMACACE O CHYBE 
                }
                Int32 sum = 0;
                foreach (byte b in _Buffer)
                    sum += b;                                                       //pocitani CRC

                _Buffer[_Buffer.Length - 4] = (byte)(sum);
                _Buffer[_Buffer.Length - 3] = (byte)(sum >> 8);
                _Buffer[_Buffer.Length - 2] = (byte)(sum >> 16);
                _Buffer[_Buffer.Length - 1] = (byte)(sum >> 24);

                mySerialPort.Write(_Buffer, 0, _Buffer.Length);                     //Posilani dat
                error_transfer = 0;
                Simulator.Self.Invoke(new Action(() =>                              //Invoke aby bylo mozne pristoupit fo hlavniho formulare
                {
                    Simulator.Self.list("Answer");                                  //Vyvola udalost pro zobrazeni dat do Listboxu
                }));
                
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());                //Vypisem chybu ktera nastala
            }
        }
        public string Get()
        {
            return BitConverter.ToString(indata);
        }
        public string Give()
        {
            return BitConverter.ToString(_Buffer);
        }
        // Kontrola CRC vypoctem prijatych dat a naslednym provnanim vrati true/false 
        private bool CRC_check(byte[] buffer_receive)
        {                                                         
            Int32 sum = 0;                                                           //pomocna promena pro vypocet CRC
            byte[] _Buff_pom = new byte[buffer_receive.Length - 1];                  //pom buffer zkraceny o CRC prichoziho
            Array.Copy(buffer_receive, 0, _Buff_pom, 0, buffer_receive.Length - 4);  //copyrovani prijateho bufferu do pomocneho bez CRC
            foreach (byte value in _Buff_pom)                                       
                sum += value;                                                        //Scitani hodnot v bufferu vypocet CRC
            Int32 rsum = (buffer_receive[(buffer_receive.Length - 1)] << 24);         //CRC velikost 4byty posíláme po bytech je proto nutný bitový součet  
            rsum |= (buffer_receive[(buffer_receive.Length - 2)] << 16);
            rsum |= (buffer_receive[(buffer_receive.Length - 3)] << 8);
            rsum |= buffer_receive[(buffer_receive.Length - 4)];

            if (sum == rsum)                                                          //Porovnani vypocteneho CRC z prijatym
                return true;
            else
            {
                error_transfer = (byte)Error.ECRC;                                   //Nastaveni chyby CRC
                return false;                                                        //Vrat info o spatnem CRC
            }
        }
        public void Uopen(){ mySerialPort.Open(); stav = true; }                     //Otevira komunikacni port
        public void Uclose(){ mySerialPort.Close(); stav = false; }                  //Zavira komunikacni port
        public bool IsOPEN() {return stav;}                                          //Vraci true nebo false podle toho jesti je COM otevren

    }
}
