using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace monitoreo
{
    public partial class Form1 : Form
    {

        String serialDataIn;
        sbyte index0fA, index0fB, index0fC, index0fD, index0fE, index0fF, index0fG;
        String dataSensor1, dataSensor2, dataSensor3, dataSensor4, dataSensor5, str_data,nivel_agua;

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            button_open.Enabled = true;
            button_close.Enabled = false;
            verticalProgressBar_statusCOM.Value = 0;
            comboBox_baudRate.Text = "115200";

        }

        private void comboBox_comPort_DropDown(object sender, EventArgs e)
        {
            String[] portLists = SerialPort.GetPortNames();
            comboBox_comPort.Items.Clear();
            comboBox_comPort.Items.AddRange(portLists);

        }

        private void button_open_Click(object sender, EventArgs e)
        {


            try
            {
                serialPort1.PortName = comboBox_comPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBox_baudRate.Text);
                serialPort1.Open();

                button_open.Enabled = false;
                button_close.Enabled = true;
                verticalProgressBar_statusCOM.Value = 100;
            }
            catch (Exception error)
            {


                MessageBox.Show(error.Message);


            }






        }

        private void button_close_Click(object sender, EventArgs e)
        {



            try
            {

                serialPort1.Close();

                button_open.Enabled = true;
                button_close.Enabled = false;
                verticalProgressBar_statusCOM.Value = 0;
            }
            catch (Exception error)
            {


                MessageBox.Show(error.Message);


            }




        }


        // serrar el puerto com

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {



            try
            {

                serialPort1.Close();


            }
            catch (Exception error)
            {


                MessageBox.Show(error.Message);


            }





        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {



            serialDataIn = serialPort1.ReadLine();
            this.BeginInvoke(new EventHandler(prossesData));





        }

        private void prossesData(object sender, EventArgs e)
        {


            try
            {


                textBox_Datain.Text = serialDataIn;


                index0fA = Convert.ToSByte(serialDataIn.IndexOf("A"));
                index0fB = Convert.ToSByte(serialDataIn.IndexOf("B"));
                index0fC = Convert.ToSByte(serialDataIn.IndexOf("C"));
                index0fD = Convert.ToSByte(serialDataIn.IndexOf("D"));
                index0fE = Convert.ToSByte(serialDataIn.IndexOf("E"));
                index0fF = Convert.ToSByte(serialDataIn.IndexOf("F"));
                index0fG = Convert.ToSByte(serialDataIn.IndexOf("G"));

                dataSensor1 = serialDataIn.Substring(0, index0fA);
                dataSensor2 = serialDataIn.Substring(index0fA + 1, (index0fB - index0fA) - 1);
                dataSensor3 = serialDataIn.Substring(index0fB + 1, (index0fC - index0fB) - 1);
                dataSensor4 = serialDataIn.Substring(index0fC + 1, (index0fD - index0fC) - 1);
                dataSensor5 = serialDataIn.Substring(index0fD + 1, (index0fE - index0fD) - 1);
                str_data = serialDataIn.Substring(index0fE + 1, (index0fF - index0fE) - 1);
                nivel_agua= serialDataIn.Substring(index0fF + 1, (index0fG - index0fF) - 1);


                textBox_SENSOR1.Text = dataSensor1;
                textBox_SENSOR2.Text = dataSensor2;
                textBox_SENSOR3.Text = dataSensor3;
                textBox_SENSOR4.Text = dataSensor4;
                textBox_SENSOR5.Text = dataSensor5;
                textBox_BOMBA.Text = str_data;
                textBox_NIVEL_AGUA.Text = nivel_agua;


                verticalProgressBar_SENSOR1.Value = Convert.ToInt32(dataSensor1);
                verticalProgressBar_SENSOR2.Value = Convert.ToInt32(dataSensor2);
                verticalProgressBar_SENSOR3.Value = Convert.ToInt32(dataSensor3);

            }
            catch (Exception error)
            {


                MessageBox.Show(error.Message);


            }




        }
    }
}