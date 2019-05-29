using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace ArduinoLEDapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void textboxBlinks_TextChanged(object sender, EventArgs e)
        {


        }

        private void buttonBlink_Click(object sender, EventArgs e)
        {
            string name = textboxBlinks.Text;
            
            if(name == "1" || name == "2" || name == "3")
            {
                messageBox.Text = "LED Blinking... ";
                BlinkArduino(name, SerialPortBegin());
            }

            else
            {
                messageBox.Text = "Incorrect Input";
            }
            



        }

        void BlinkArduino(string name, SerialPort _serialPort)
        {

            string associatedString;
            

            Thread.Sleep(200);

            if (name == "1")
            {
                associatedString = "A";
            }

            else if (name == "2")
            {
                associatedString = "B";
            }

            else if (name == "3")
            {
                associatedString = "C";
                textboxReadVoltage.Text = "C";
               
            }

            else
            {
                associatedString = null;
            }

            _serialPort.Write(associatedString);

            Thread.Sleep(200);

            messageBox.Text = _serialPort.ReadLine();
            _serialPort.Close();

        }

        private void ledBlinks_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonMotorOn_Click(object sender, EventArgs e)
        {

        }

        private SerialPort SerialPortBegin()
        {
            SerialPort _serialPort = new SerialPort();
            _serialPort.PortName = "COM5";
            _serialPort.BaudRate = 9600;
            _serialPort.Open();

            return _serialPort;
        }
    }
}
