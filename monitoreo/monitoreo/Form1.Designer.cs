namespace monitoreo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_NIVEL_AGUA = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_BOMBA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_Datain = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_SENSOR5 = new System.Windows.Forms.TextBox();
            this.textBox_SENSOR4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_SENSOR3 = new System.Windows.Forms.TextBox();
            this.verticalProgressBar_SENSOR3 = new monitoreo.verticalProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_SENSOR2 = new System.Windows.Forms.TextBox();
            this.verticalProgressBar_SENSOR2 = new monitoreo.verticalProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_SENSOR1 = new System.Windows.Forms.TextBox();
            this.verticalProgressBar_SENSOR1 = new monitoreo.verticalProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.verticalProgressBar_statusCOM = new monitoreo.verticalProgressBar();
            this.button_close = new System.Windows.Forms.Button();
            this.button_open = new System.Windows.Forms.Button();
            this.comboBox_baudRate = new System.Windows.Forms.ComboBox();
            this.comboBox_comPort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.textBox_NIVEL_AGUA);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBox_BOMBA);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBox_Datain);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox_SENSOR5);
            this.panel1.Controls.Add(this.textBox_SENSOR4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox_SENSOR3);
            this.panel1.Controls.Add(this.verticalProgressBar_SENSOR3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox_SENSOR2);
            this.panel1.Controls.Add(this.verticalProgressBar_SENSOR2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox_SENSOR1);
            this.panel1.Controls.Add(this.verticalProgressBar_SENSOR1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 322);
            this.panel1.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(83, 147);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 30;
            this.label17.Text = "100 %";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(243, 147);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "100ºC";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(245, 255);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "0 ºC";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(83, 255);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "0%";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(411, 253);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "0ºF";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(411, 142);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "212ºF";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(670, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Particulas por millón";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(154, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Nivel de tanque de agua:";
            // 
            // textBox_NIVEL_AGUA
            // 
            this.textBox_NIVEL_AGUA.Location = new System.Drawing.Point(309, 24);
            this.textBox_NIVEL_AGUA.Multiline = true;
            this.textBox_NIVEL_AGUA.Name = "textBox_NIVEL_AGUA";
            this.textBox_NIVEL_AGUA.Size = new System.Drawing.Size(195, 27);
            this.textBox_NIVEL_AGUA.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(204, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Estado de riego:";
            // 
            // textBox_BOMBA
            // 
            this.textBox_BOMBA.Location = new System.Drawing.Point(309, 57);
            this.textBox_BOMBA.Multiline = true;
            this.textBox_BOMBA.Name = "textBox_BOMBA";
            this.textBox_BOMBA.Size = new System.Drawing.Size(195, 27);
            this.textBox_BOMBA.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(486, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Data In";
            // 
            // textBox_Datain
            // 
            this.textBox_Datain.Location = new System.Drawing.Point(541, 253);
            this.textBox_Datain.Multiline = true;
            this.textBox_Datain.Name = "textBox_Datain";
            this.textBox_Datain.Size = new System.Drawing.Size(247, 20);
            this.textBox_Datain.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(499, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Estado del agua";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(520, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "PH del agua";
            // 
            // textBox_SENSOR5
            // 
            this.textBox_SENSOR5.Location = new System.Drawing.Point(603, 147);
            this.textBox_SENSOR5.Name = "textBox_SENSOR5";
            this.textBox_SENSOR5.Size = new System.Drawing.Size(59, 20);
            this.textBox_SENSOR5.TabIndex = 14;
            // 
            // textBox_SENSOR4
            // 
            this.textBox_SENSOR4.Location = new System.Drawing.Point(603, 105);
            this.textBox_SENSOR4.Name = "textBox_SENSOR4";
            this.textBox_SENSOR4.Size = new System.Drawing.Size(59, 20);
            this.textBox_SENSOR4.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(312, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Temperatura en grados farenheit";
            // 
            // textBox_SENSOR3
            // 
            this.textBox_SENSOR3.Location = new System.Drawing.Point(346, 269);
            this.textBox_SENSOR3.Name = "textBox_SENSOR3";
            this.textBox_SENSOR3.Size = new System.Drawing.Size(59, 20);
            this.textBox_SENSOR3.TabIndex = 11;
            // 
            // verticalProgressBar_SENSOR3
            // 
            this.verticalProgressBar_SENSOR3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.verticalProgressBar_SENSOR3.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.verticalProgressBar_SENSOR3.Location = new System.Drawing.Point(354, 142);
            this.verticalProgressBar_SENSOR3.Maximum = 212;
            this.verticalProgressBar_SENSOR3.Name = "verticalProgressBar_SENSOR3";
            this.verticalProgressBar_SENSOR3.Size = new System.Drawing.Size(51, 121);
            this.verticalProgressBar_SENSOR3.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(105, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Temperatura en grados centigrados";
            // 
            // textBox_SENSOR2
            // 
            this.textBox_SENSOR2.Location = new System.Drawing.Point(184, 274);
            this.textBox_SENSOR2.Name = "textBox_SENSOR2";
            this.textBox_SENSOR2.Size = new System.Drawing.Size(59, 20);
            this.textBox_SENSOR2.TabIndex = 8;
            // 
            // verticalProgressBar_SENSOR2
            // 
            this.verticalProgressBar_SENSOR2.Location = new System.Drawing.Point(188, 147);
            this.verticalProgressBar_SENSOR2.Name = "verticalProgressBar_SENSOR2";
            this.verticalProgressBar_SENSOR2.Size = new System.Drawing.Size(51, 121);
            this.verticalProgressBar_SENSOR2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Humedad en %";
            // 
            // textBox_SENSOR1
            // 
            this.textBox_SENSOR1.Location = new System.Drawing.Point(22, 274);
            this.textBox_SENSOR1.Name = "textBox_SENSOR1";
            this.textBox_SENSOR1.Size = new System.Drawing.Size(59, 20);
            this.textBox_SENSOR1.TabIndex = 3;
            // 
            // verticalProgressBar_SENSOR1
            // 
            this.verticalProgressBar_SENSOR1.Location = new System.Drawing.Point(26, 147);
            this.verticalProgressBar_SENSOR1.Name = "verticalProgressBar_SENSOR1";
            this.verticalProgressBar_SENSOR1.Size = new System.Drawing.Size(51, 121);
            this.verticalProgressBar_SENSOR1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.verticalProgressBar_statusCOM);
            this.groupBox1.Controls.Add(this.button_close);
            this.groupBox1.Controls.Add(this.button_open);
            this.groupBox1.Controls.Add(this.comboBox_baudRate);
            this.groupBox1.Controls.Add(this.comboBox_comPort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 328);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 122);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuracion de COM";
            // 
            // verticalProgressBar_statusCOM
            // 
            this.verticalProgressBar_statusCOM.Location = new System.Drawing.Point(137, 10);
            this.verticalProgressBar_statusCOM.Name = "verticalProgressBar_statusCOM";
            this.verticalProgressBar_statusCOM.Size = new System.Drawing.Size(51, 106);
            this.verticalProgressBar_statusCOM.TabIndex = 6;
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.Red;
            this.button_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_close.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_close.Location = new System.Drawing.Point(659, 87);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 5;
            this.button_close.Text = "close";
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_open
            // 
            this.button_open.BackColor = System.Drawing.Color.Lime;
            this.button_open.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_open.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.button_open.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.button_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_open.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_open.ForeColor = System.Drawing.Color.Black;
            this.button_open.Location = new System.Drawing.Point(659, 53);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(75, 23);
            this.button_open.TabIndex = 4;
            this.button_open.Text = "open";
            this.button_open.UseVisualStyleBackColor = false;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // comboBox_baudRate
            // 
            this.comboBox_baudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_baudRate.FormattingEnabled = true;
            this.comboBox_baudRate.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.comboBox_baudRate.Location = new System.Drawing.Point(517, 87);
            this.comboBox_baudRate.Name = "comboBox_baudRate";
            this.comboBox_baudRate.Size = new System.Drawing.Size(121, 21);
            this.comboBox_baudRate.TabIndex = 3;
            // 
            // comboBox_comPort
            // 
            this.comboBox_comPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_comPort.FormattingEnabled = true;
            this.comboBox_comPort.Location = new System.Drawing.Point(284, 90);
            this.comboBox_comPort.Name = "comboBox_comPort";
            this.comboBox_comPort.Size = new System.Drawing.Size(121, 21);
            this.comboBox_comPort.TabIndex = 2;
            this.comboBox_comPort.DropDown += new System.EventHandler(this.comboBox_comPort_DropDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(434, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "BAUD RATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM PORT";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MONITOREO_SOFTWARE_HUVA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_baudRate;
        private System.Windows.Forms.ComboBox comboBox_comPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_open;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private verticalProgressBar verticalProgressBar_SENSOR1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_SENSOR3;
        private verticalProgressBar verticalProgressBar_SENSOR3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_SENSOR2;
        private verticalProgressBar verticalProgressBar_SENSOR2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_SENSOR1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_SENSOR5;
        private System.Windows.Forms.TextBox textBox_SENSOR4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_Datain;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_BOMBA;
        private verticalProgressBar verticalProgressBar_statusCOM;
        private System.Windows.Forms.TextBox textBox_NIVEL_AGUA;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}

