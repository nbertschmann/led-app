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
            string[] comPortArray = SerialPort.GetPortNames();
            int arrayLength = comPortArray.Length;
            string arrayLengthString = arrayLength.ToString();
            messageBox.Text = comPortArray[0] + comPortArray[1] + comPortArray[2];
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
            messageBox.Text = "Turning Motor Off..";
            motorOff(SerialPortBegin());
        }

        private void LedON_Click(object sender, EventArgs e)
        {
            messageBox.Text = "Turning Red LED On..";
            redLedOn(SerialPortBegin());
        }

        private void LedOFF_Click(object sender, EventArgs e)
        {
            messageBox.Text = "Turning Red LED Off..";
            redLedOff(SerialPortBegin());
        }

        private void buttonReadVoltage_Click(object sender, EventArgs e)
        {
            messageBox.Text = "Reading Voltage..";
            readVoltage(SerialPortBegin());
        }

        private void BlinkArduino(string name, SerialPort _serialPort)
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

        private void redLedOn(SerialPort _serialPort)
        {
            _serialPort.Write("D");
            Thread.Sleep(200);
            _serialPort.Close();
        }

        private void redLedOff(SerialPort _serialPort)
        {
            _serialPort.Write("E");
            Thread.Sleep(200);
            _serialPort.Close();
        }

        private void motorOn(SerialPort _serialPort)
        {
            _serialPort.Write("F");
            Thread.Sleep(200);
            _serialPort.Close();
        }

        private void motorOff(SerialPort _serialPort)
        {
            _serialPort.Write("G");
            Thread.Sleep(200);
            _serialPort.Close();
        }


        private void readVoltage(SerialPort _serialPort)
        {
            _serialPort.Write("H");

            Thread.Sleep(200);
            string voltageReading = _serialPort.ReadExisting();
            textboxReadVoltage.Text = voltageReading;
            
            
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

    }
}
