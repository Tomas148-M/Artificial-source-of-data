namespace Car_unit_simulator
{
    partial class Simulator
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serial_group = new System.Windows.Forms.GroupBox();
            this.paritybits = new System.Windows.Forms.ComboBox();
            this.stopbits = new System.Windows.Forms.ComboBox();
            this.databits = new System.Windows.Forms.ComboBox();
            this.baud = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.com = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.openclose = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Car_info = new System.Windows.Forms.Label();
            this.Test_komunikace = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.real_time = new System.Windows.Forms.Label();
            this.Car_information = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.voltage_edit = new System.Windows.Forms.TextBox();
            this.voltage = new System.Windows.Forms.Label();
            this.totalt = new System.Windows.Forms.Label();
            this.total_edit = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.fuel_level_edit = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.trip_km_edit = new System.Windows.Forms.TextBox();
            this.temp_in_edit = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.temp_out_edit = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.GPS = new System.Windows.Forms.GroupBox();
            this.satellite_edit = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.quality_edit = new System.Windows.Forms.TextBox();
            this.height_edit = new System.Windows.Forms.TextBox();
            this.speed_edit = new System.Windows.Forms.TextBox();
            this.lattitude_edit = new System.Windows.Forms.TextBox();
            this.longitude_edit = new System.Windows.Forms.TextBox();
            this.Longitude = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Output1 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.Output2 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.Output3 = new System.Windows.Forms.Panel();
            this.serial_group.SuspendLayout();
            this.Test_komunikace.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.Car_information.SuspendLayout();
            this.GPS.SuspendLayout();
            this.SuspendLayout();
            // 
            // serial_group
            // 
            this.serial_group.Controls.Add(this.paritybits);
            this.serial_group.Controls.Add(this.stopbits);
            this.serial_group.Controls.Add(this.databits);
            this.serial_group.Controls.Add(this.baud);
            this.serial_group.Controls.Add(this.label5);
            this.serial_group.Controls.Add(this.label4);
            this.serial_group.Controls.Add(this.label3);
            this.serial_group.Controls.Add(this.label2);
            this.serial_group.Controls.Add(this.com);
            this.serial_group.Controls.Add(this.label1);
            this.serial_group.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serial_group.ForeColor = System.Drawing.Color.White;
            this.serial_group.Location = new System.Drawing.Point(6, 287);
            this.serial_group.Name = "serial_group";
            this.serial_group.Size = new System.Drawing.Size(191, 209);
            this.serial_group.TabIndex = 2;
            this.serial_group.TabStop = false;
            this.serial_group.Text = "COM port control";
            // 
            // paritybits
            // 
            this.paritybits.FormattingEnabled = true;
            this.paritybits.Items.AddRange(new object[] {
            "none",
            "Mark",
            "Even",
            "Odd",
            "Space"});
            this.paritybits.Location = new System.Drawing.Point(73, 173);
            this.paritybits.Name = "paritybits";
            this.paritybits.Size = new System.Drawing.Size(102, 21);
            this.paritybits.TabIndex = 9;
            // 
            // stopbits
            // 
            this.stopbits.FormattingEnabled = true;
            this.stopbits.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.stopbits.Location = new System.Drawing.Point(73, 134);
            this.stopbits.Name = "stopbits";
            this.stopbits.Size = new System.Drawing.Size(102, 21);
            this.stopbits.TabIndex = 8;
            // 
            // databits
            // 
            this.databits.FormattingEnabled = true;
            this.databits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.databits.Location = new System.Drawing.Point(73, 96);
            this.databits.Name = "databits";
            this.databits.Size = new System.Drawing.Size(102, 21);
            this.databits.TabIndex = 7;
            // 
            // baud
            // 
            this.baud.FormattingEnabled = true;
            this.baud.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200"});
            this.baud.Location = new System.Drawing.Point(73, 60);
            this.baud.Name = "baud";
            this.baud.Size = new System.Drawing.Size(102, 21);
            this.baud.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(5, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Parity bits:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Stop bits:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data Bits:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baudrate:";
            // 
            // com
            // 
            this.com.BackColor = System.Drawing.SystemColors.Window;
            this.com.FormattingEnabled = true;
            this.com.Location = new System.Drawing.Point(73, 22);
            this.com.Name = "com";
            this.com.Size = new System.Drawing.Size(102, 21);
            this.com.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Com Port:";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Black;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(218, 278);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(616, 260);
            this.listBox1.TabIndex = 3;
            // 
            // openclose
            // 
            this.openclose.BackColor = System.Drawing.SystemColors.Control;
            this.openclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.openclose.ForeColor = System.Drawing.Color.Black;
            this.openclose.Location = new System.Drawing.Point(6, 508);
            this.openclose.Name = "openclose";
            this.openclose.Size = new System.Drawing.Size(191, 29);
            this.openclose.TabIndex = 4;
            this.openclose.Text = "Open";
            this.openclose.UseVisualStyleBackColor = false;
            this.openclose.Click += new System.EventHandler(this.openclose_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "GPS",
            "Car_info",
            "Test"});
            this.comboBox1.Location = new System.Drawing.Point(258, 156);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(109, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Car_info
            // 
            this.Car_info.AutoSize = true;
            this.Car_info.ForeColor = System.Drawing.Color.Black;
            this.Car_info.Location = new System.Drawing.Point(255, 134);
            this.Car_info.Name = "Car_info";
            this.Car_info.Size = new System.Drawing.Size(112, 13);
            this.Car_info.TabIndex = 8;
            this.Car_info.Text = "Select visible data";
            // 
            // Test_komunikace
            // 
            this.Test_komunikace.Controls.Add(this.textBox1);
            this.Test_komunikace.Controls.Add(this.label14);
            this.Test_komunikace.ForeColor = System.Drawing.Color.White;
            this.Test_komunikace.Location = new System.Drawing.Point(429, 51);
            this.Test_komunikace.Name = "Test_komunikace";
            this.Test_komunikace.Size = new System.Drawing.Size(405, 209);
            this.Test_komunikace.TabIndex = 19;
            this.Test_komunikace.TabStop = false;
            this.Test_komunikace.Text = "Test_komunikace";
            this.Test_komunikace.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 20);
            this.textBox1.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(18, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Temp IN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(249)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.serial_group);
            this.panel1.Controls.Add(this.openclose);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 554);
            this.panel1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Car_unit_simulator.Properties.Resources.iconfinder_cpu__chip__electronics__applet__microchip__proceesor__pc_2317963;
            this.pictureBox1.Location = new System.Drawing.Point(37, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 137);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(804, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 27);
            this.button1.TabIndex = 26;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Minimize
            // 
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.ForeColor = System.Drawing.Color.Black;
            this.Minimize.Location = new System.Drawing.Point(766, 10);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(30, 27);
            this.Minimize.TabIndex = 25;
            this.Minimize.Text = "-";
            this.Minimize.UseVisualStyleBackColor = true;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.real_time);
            this.panel2.Location = new System.Drawing.Point(248, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(127, 40);
            this.panel2.TabIndex = 28;
            // 
            // real_time
            // 
            this.real_time.AutoSize = true;
            this.real_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.real_time.ForeColor = System.Drawing.Color.Black;
            this.real_time.Location = new System.Drawing.Point(12, 8);
            this.real_time.Name = "real_time";
            this.real_time.Size = new System.Drawing.Size(104, 25);
            this.real_time.TabIndex = 0;
            this.real_time.Text = "00:00:00";
            // 
            // Car_information
            // 
            this.Car_information.Controls.Add(this.button2);
            this.Car_information.Controls.Add(this.voltage_edit);
            this.Car_information.Controls.Add(this.voltage);
            this.Car_information.Controls.Add(this.totalt);
            this.Car_information.Controls.Add(this.total_edit);
            this.Car_information.Controls.Add(this.label15);
            this.Car_information.Controls.Add(this.fuel_level_edit);
            this.Car_information.Controls.Add(this.label11);
            this.Car_information.Controls.Add(this.trip_km_edit);
            this.Car_information.Controls.Add(this.temp_in_edit);
            this.Car_information.Controls.Add(this.label12);
            this.Car_information.Controls.Add(this.temp_out_edit);
            this.Car_information.Controls.Add(this.label13);
            this.Car_information.ForeColor = System.Drawing.Color.White;
            this.Car_information.Location = new System.Drawing.Point(429, 51);
            this.Car_information.Name = "Car_information";
            this.Car_information.Size = new System.Drawing.Size(405, 209);
            this.Car_information.TabIndex = 29;
            this.Car_information.TabStop = false;
            this.Car_information.Text = "Car info - Generovana data";
            this.Car_information.Visible = false;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(280, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 23);
            this.button2.TabIndex = 37;
            this.button2.Text = "refuel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // voltage_edit
            // 
            this.voltage_edit.Location = new System.Drawing.Point(280, 24);
            this.voltage_edit.Name = "voltage_edit";
            this.voltage_edit.Size = new System.Drawing.Size(116, 20);
            this.voltage_edit.TabIndex = 27;
            // 
            // voltage
            // 
            this.voltage.AutoSize = true;
            this.voltage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.voltage.Location = new System.Drawing.Point(211, 26);
            this.voltage.Name = "voltage";
            this.voltage.Size = new System.Drawing.Size(70, 13);
            this.voltage.TabIndex = 26;
            this.voltage.Text = "Voltage [V]";
            // 
            // totalt
            // 
            this.totalt.AutoSize = true;
            this.totalt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.totalt.Location = new System.Drawing.Point(15, 143);
            this.totalt.Name = "totalt";
            this.totalt.Size = new System.Drawing.Size(64, 13);
            this.totalt.TabIndex = 25;
            this.totalt.Text = "Total [km]";
            // 
            // total_edit
            // 
            this.total_edit.Location = new System.Drawing.Point(85, 139);
            this.total_edit.Name = "total_edit";
            this.total_edit.Size = new System.Drawing.Size(116, 20);
            this.total_edit.TabIndex = 24;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Location = new System.Drawing.Point(27, 180);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "Fuel [l]";
            // 
            // fuel_level_edit
            // 
            this.fuel_level_edit.Location = new System.Drawing.Point(85, 178);
            this.fuel_level_edit.Name = "fuel_level_edit";
            this.fuel_level_edit.Size = new System.Drawing.Size(116, 20);
            this.fuel_level_edit.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(19, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Trip [km]";
            // 
            // trip_km_edit
            // 
            this.trip_km_edit.Location = new System.Drawing.Point(85, 99);
            this.trip_km_edit.Name = "trip_km_edit";
            this.trip_km_edit.Size = new System.Drawing.Size(116, 20);
            this.trip_km_edit.TabIndex = 19;
            // 
            // temp_in_edit
            // 
            this.temp_in_edit.Location = new System.Drawing.Point(85, 24);
            this.temp_in_edit.Name = "temp_in_edit";
            this.temp_in_edit.ReadOnly = true;
            this.temp_in_edit.Size = new System.Drawing.Size(116, 20);
            this.temp_in_edit.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(2, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Temp out[°C]";
            // 
            // temp_out_edit
            // 
            this.temp_out_edit.Location = new System.Drawing.Point(85, 62);
            this.temp_out_edit.Name = "temp_out_edit";
            this.temp_out_edit.Size = new System.Drawing.Size(116, 20);
            this.temp_out_edit.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(6, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Temp in [°C]";
            // 
            // GPS
            // 
            this.GPS.Controls.Add(this.satellite_edit);
            this.GPS.Controls.Add(this.label10);
            this.GPS.Controls.Add(this.label9);
            this.GPS.Controls.Add(this.label8);
            this.GPS.Controls.Add(this.label7);
            this.GPS.Controls.Add(this.label6);
            this.GPS.Controls.Add(this.quality_edit);
            this.GPS.Controls.Add(this.height_edit);
            this.GPS.Controls.Add(this.speed_edit);
            this.GPS.Controls.Add(this.lattitude_edit);
            this.GPS.Controls.Add(this.longitude_edit);
            this.GPS.Controls.Add(this.Longitude);
            this.GPS.ForeColor = System.Drawing.Color.White;
            this.GPS.Location = new System.Drawing.Point(429, 51);
            this.GPS.Name = "GPS";
            this.GPS.Size = new System.Drawing.Size(405, 209);
            this.GPS.TabIndex = 30;
            this.GPS.TabStop = false;
            this.GPS.Text = "GPS - Generovana data";
            // 
            // satellite_edit
            // 
            this.satellite_edit.Location = new System.Drawing.Point(279, 24);
            this.satellite_edit.Name = "satellite_edit";
            this.satellite_edit.Size = new System.Drawing.Size(116, 20);
            this.satellite_edit.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(212, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "satellite [-]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(15, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "quality [-]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(11, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Height [m]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(8, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Speed [km]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(7, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Latitude [N]";
            // 
            // quality_edit
            // 
            this.quality_edit.Location = new System.Drawing.Point(85, 175);
            this.quality_edit.Name = "quality_edit";
            this.quality_edit.Size = new System.Drawing.Size(116, 20);
            this.quality_edit.TabIndex = 6;
            // 
            // height_edit
            // 
            this.height_edit.Location = new System.Drawing.Point(85, 138);
            this.height_edit.Name = "height_edit";
            this.height_edit.Size = new System.Drawing.Size(116, 20);
            this.height_edit.TabIndex = 5;
            // 
            // speed_edit
            // 
            this.speed_edit.Location = new System.Drawing.Point(85, 100);
            this.speed_edit.Name = "speed_edit";
            this.speed_edit.Size = new System.Drawing.Size(116, 20);
            this.speed_edit.TabIndex = 4;
            // 
            // lattitude_edit
            // 
            this.lattitude_edit.Location = new System.Drawing.Point(85, 62);
            this.lattitude_edit.Name = "lattitude_edit";
            this.lattitude_edit.Size = new System.Drawing.Size(116, 20);
            this.lattitude_edit.TabIndex = 3;
            // 
            // longitude_edit
            // 
            this.longitude_edit.Location = new System.Drawing.Point(85, 24);
            this.longitude_edit.Name = "longitude_edit";
            this.longitude_edit.Size = new System.Drawing.Size(116, 20);
            this.longitude_edit.TabIndex = 1;
            // 
            // Longitude
            // 
            this.Longitude.AutoSize = true;
            this.Longitude.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Longitude.Location = new System.Drawing.Point(2, 27);
            this.Longitude.Name = "Longitude";
            this.Longitude.Size = new System.Drawing.Size(83, 13);
            this.Longitude.TabIndex = 0;
            this.Longitude.Text = "Longitude [E]";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(215, 207);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "Output_1";
            // 
            // Output1
            // 
            this.Output1.BackColor = System.Drawing.Color.White;
            this.Output1.Location = new System.Drawing.Point(230, 227);
            this.Output1.Name = "Output1";
            this.Output1.Size = new System.Drawing.Size(18, 18);
            this.Output1.TabIndex = 32;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(285, 207);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 13);
            this.label17.TabIndex = 33;
            this.label17.Text = "Output_2";
            // 
            // Output2
            // 
            this.Output2.BackColor = System.Drawing.Color.White;
            this.Output2.Location = new System.Drawing.Point(301, 226);
            this.Output2.Name = "Output2";
            this.Output2.Size = new System.Drawing.Size(18, 18);
            this.Output2.TabIndex = 34;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(358, 207);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "Output_3";
            // 
            // Output3
            // 
            this.Output3.BackColor = System.Drawing.Color.White;
            this.Output3.Location = new System.Drawing.Point(373, 226);
            this.Output3.Name = "Output3";
            this.Output3.Size = new System.Drawing.Size(18, 18);
            this.Output3.TabIndex = 35;
            // 
            // Simulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(112)))), ((int)(((byte)(113)))));
            this.ClientSize = new System.Drawing.Size(851, 552);
            this.Controls.Add(this.Output3);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.Output2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.Output1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.GPS);
            this.Controls.Add(this.Car_information);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Test_komunikace);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Car_info);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Simulator";
            this.Text = "Simulator data";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Simulator_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Simulator_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Simulator_MouseUp);
            this.serial_group.ResumeLayout(false);
            this.serial_group.PerformLayout();
            this.Test_komunikace.ResumeLayout(false);
            this.Test_komunikace.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Car_information.ResumeLayout(false);
            this.Car_information.PerformLayout();
            this.GPS.ResumeLayout(false);
            this.GPS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox serial_group;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox com;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox paritybits;
        private System.Windows.Forms.ComboBox stopbits;
        private System.Windows.Forms.ComboBox databits;
        private System.Windows.Forms.ComboBox baud;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button openclose;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Car_info;
        private System.Windows.Forms.GroupBox Test_komunikace;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label real_time;
        private System.Windows.Forms.GroupBox Car_information;
        private System.Windows.Forms.TextBox voltage_edit;
        private System.Windows.Forms.Label voltage;
        private System.Windows.Forms.Label totalt;
        private System.Windows.Forms.TextBox total_edit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox fuel_level_edit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox trip_km_edit;
        private System.Windows.Forms.TextBox temp_in_edit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox temp_out_edit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox GPS;
        private System.Windows.Forms.TextBox satellite_edit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox quality_edit;
        private System.Windows.Forms.TextBox height_edit;
        private System.Windows.Forms.TextBox speed_edit;
        private System.Windows.Forms.TextBox lattitude_edit;
        private System.Windows.Forms.TextBox longitude_edit;
        private System.Windows.Forms.Label Longitude;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel Output1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel Output2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel Output3;
        private System.Windows.Forms.Button button2;
    }
}

