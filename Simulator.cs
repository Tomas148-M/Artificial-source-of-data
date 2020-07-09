using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
//Pridane moduly
using System.IO.Ports;
using System.Timers;    

namespace Car_unit_simulator
{
    public partial class Simulator : Form
    {
        public static Simulator Self;
        private static System.Timers.Timer aTimer;
        SerialLine uart = null;
        static bool generate = false;

        private int posX;
        private int posY;
        private int pos;
        private byte last = 0;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public Simulator()
        {
            InitializeComponent();
            Self = this;
            uart = new SerialLine(this);

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            Combo_value();
            comboBox1.SelectedIndex = 0;

            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(1000);                                             //NASTAV DOBU PRERUSENI TIMERU
            // Hook up the Elapsed event for the timer.                                         
            aTimer.Elapsed += TimedEvent;                                                       //NASTAVENI FUNKCE KTERA SE MA ZAVOLAT PRI PRERUSENI
            aTimer.AutoReset = true;                                                            //POVOLENI AUTO RESETU
            aTimer.Enabled = true;                                                              //POVOLENI TIMERU

            listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;                // 
            listBox1.MeasureItem += lst_MeasureItem;                                            //      
            listBox1.DrawItem += lst_DrawItem;                                                  //*/
        }
  
      
        private void TimedEvent(Object source, ElapsedEventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                real_time.Text = DateTime.Now.ToString("HH:mm:ss");
            }));
        }
        //Aktualzace hodnot ve formmu
        public void Update(string obj,string value)
        {
            switch (obj)
            {
                //Operace mezi vlakny proto je pouzit MethodInvoke
                case "longtitude":
                    longitude_edit.Invoke((MethodInvoker)(() => longitude_edit.Text = value));
                    break;
                case "lattitude":
                    lattitude_edit.Invoke((MethodInvoker)(() => lattitude_edit.Text = value));
                    break;
                case "speed":
                    speed_edit.Invoke((MethodInvoker)(() => speed_edit.Text = value));
                    break;
                case "height":
                    height_edit.Invoke((MethodInvoker)(() => height_edit.Text = value));
                    break;
                case "satelity":
                    satellite_edit.Invoke((MethodInvoker)(() => satellite_edit.Text = value));
                    break;
                case "quality":
                    quality_edit.Invoke((MethodInvoker)(() => quality_edit.Text = value));
                    break;

                case "temp_in":
                    temp_in_edit.Invoke((MethodInvoker)(() => temp_in_edit.Text = value));
                    break;
                case "temp_out":
                    temp_out_edit.Invoke((MethodInvoker)(() => temp_out_edit.Text = value));
                    break;
                case "fuel":
                    fuel_level_edit.Invoke((MethodInvoker)(() => fuel_level_edit.Text = value));
                    break;
                case "trip":
                    trip_km_edit.Invoke((MethodInvoker)(() => trip_km_edit.Text = value));
                    break;
                case "total":
                    total_edit.Invoke((MethodInvoker)(() => total_edit.Text = value));
                    break;
                case "voltage":
                    voltage_edit.Invoke((MethodInvoker)(() => voltage_edit.Text = value));
                    break;
                case "Output1":
                    if(value == "1")
                        Output1.Invoke((MethodInvoker)(() => Output1.BackColor = Color.Green));
                    else
                        Output1.Invoke((MethodInvoker)(() => Output1.BackColor = Color.White));
                    break;
                case "Output2":
                    if (value == "1")
                        Output2.Invoke((MethodInvoker)(() => Output2.BackColor = Color.Green));
                    else
                        Output2.Invoke((MethodInvoker)(() => Output2.BackColor = Color.White));
                    break;
                case "Output3":
                    if (value == "1")
                        Output3.Invoke((MethodInvoker)(() => Output3.BackColor = Color.Green));
                    else
                        Output3.Invoke((MethodInvoker)(() => Output3.BackColor = Color.White));
                    break;
            }
        }
        // Pridani zazaznamu do listu historie zprav
        public void list(string type)
        {
            try
            {
                if (type == "Request")
                    listBox1.Items.Insert(0, DateTime.Now.ToString("HH:mm:ss") + " Request " + uart.Get());
                if (type == "Answer")
                {
                    listBox1.Items.Insert(1, DateTime.Now.ToString("HH:mm:ss") + " Answer  " + uart.Give());
                    listBox1.Items.Insert(2, " ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // Nastaveni pocatecnich hodnot prenosu
        void Combo_value()
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string b in ports)
                com.Items.Add(b);
            // com.SelectedIndex = 
            //com.FindStringExact(SerialPort);
            com.SelectedIndex = 0;
            baud.SelectedIndex = 5;
            databits.SelectedIndex = 3;
            stopbits.SelectedIndex = 0;
            paritybits.SelectedIndex = 0;
            
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            if (generate == false)
            {
                generate = true;
                GPS.Enabled = true;
            }
            else { 
                generate = false;
            }
        }
        // Open seriioveho kanalu pro prenos dat
        private void openclose_Click(object sender, EventArgs e)
        {
            try
            {
                if (uart.IsOPEN())
                {
                    uart.Uclose();
                    openclose.Text = "Open";
                    serial_group.Enabled = true;
                    openclose.BackColor = Color.White;
                }
                else
                {

                    uart.Serial_setting(com.Text,
                                        Int32.Parse(baud.Text), 
                                        paritybits.Text,
                                        Int16.Parse(databits.Text),
                                        stopbits.Text
                                        );

                    
                    serial_group.Enabled = false;
                    uart.Uopen();
                    openclose.Text = "Opened";              //NASTAVENI TEXTU NA TLACITKU OPEN SERIAL PORT
                    openclose.BackColor = Color.Green;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        // Vyber dat pro zobrazeni na formulari
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int select = comboBox1.SelectedIndex;
            switch (last)
            {
                case 1:
                    GPS.Visible = false;
                    break;
                case 2:
                    Car_information.Visible = false;
                    break;
                case 3:
                    Test_komunikace.Visible = false;
                    break;
            }
            switch (select+1)
            {
                case 1:
                    GPS.Visible = true;
                    last = 1;
                    break;
                case 2:
                    Car_information.Visible = true;
                    last = 2;
                    break;
                case 3:
                    Test_komunikace.Visible = true;
                    last = 3;
                    break;
            }
        }
        // Udalosti pro zajisteni pohybu formulare
        private void Simulator_MouseDown(object sender, MouseEventArgs e)
        {
            pos = 1;            //nastaveni promenne ktera indikuje zam4knuti mysi
            posX = e.X;         //Aktualni x pozice mysi
            posY = e.Y;         //Aktualni y pozice mysi
        }

        private void Simulator_MouseUp(object sender, MouseEventArgs e)
        {
            pos = 0;
        }
        private void Simulator_MouseMove(object sender, MouseEventArgs e)
        {
            if (pos == 1)   //Jestlize je stisknute nastavuji se souradnice okna aplikace podle pozice mysi
            {
                this.SetDesktopLocation(MousePosition.X - posX, MousePosition.Y - posY);
            }
        }
        //Zavreni aplikace
        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();    
        }
        //Minimalizace aplikace
        private void Minimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;       //Minimalizace okna
        }
     
        private void lst_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = (int)e.Graphics.MeasureString(listBox1.Items[e.Index].ToString(), listBox1.Font, listBox1.Width).Height;
        }
        //Zapsani zaznamu do listboxu 
        private void lst_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if(e.Index >= 0)
                e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);             
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            uart.Servis_modul.Set_fuel();       //Nastaveni promenne pro benzin
        }
    }
}
