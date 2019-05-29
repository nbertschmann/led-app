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

        
        private void ledBlinks_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonMotorOn_Click(object sender, EventArgs e)
        {
            messageBox.Text = "Motor Turned On";
            motorOn(SerialPortBegin());
        }

        private void buttonMotorOff_Click(object sender, EventArgs e)
        {
            messageBox.Text = "Motor Turned Off";
            motorOff(SerialPortBegin());
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
            }

            else
            {
                associatedString = null;
            }

            _serialPort.Write(associatedString);

            Thread.Sleep(200);

            // messageBox.Text = _serialPort.ReadLine();
            _serialPort.Close();

        }

        void redLedOn(SerialPort _serialPort)
        {
            _serialPort.Write("D");
            Thread.Sleep(200);
            _serialPort.Close();
        }

        void redLedOff(SerialPort _serialPort)
        {
            _serialPort.Write("E");
            Thread.Sleep(200);
            _serialPort.Close();
        }

        void motorOn(SerialPort _serialPort)
        {
            _serialPort.Write("F");
            Thread.Sleep(200);
            _serialPort.Close();
        }

        void motorOff(SerialPort _serialPort)
        {
            _serialPort.Write("G");
            Thread.Sleep(200);
            _serialPort.Close();
        }

        private SerialPort SerialPortBegin()
        {
            SerialPort _serialPort = new SerialPort();
            _serialPort.PortName = "COM5";
            _serialPort.BaudRate = 9600;
            _serialPort.Open();

            return _serialPort;
        }

        private void LedON_Click(object sender, EventArgs e)
        {
            messageBox.Text = "Red LED Turned On";
            redLedOn(SerialPortBegin());
        }

        private void LedOFF_Click(object sender, EventArgs e)
        {
            messageBox.Text = "Red LED Turned Off";
            redLedOff(SerialPortBegin());
        }
    }
}
