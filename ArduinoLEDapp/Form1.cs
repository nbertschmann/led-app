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

        //Serial port names are gathered and displayed on the combobox. All other buttons disabled until a COM port is selected
        public Form1()
        {
            InitializeComponent();
            string[] comPortArray = SerialPort.GetPortNames();

            //make output textboxes read only
            textboxReadVoltage.ReadOnly = true;
            messageBox.ReadOnly = true;

            //combobox initialized with COM port names
            comboBoxAvailableComPorts.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAvailableComPorts.Items.AddRange(comPortArray);

            disableBoxes();

            
        }

        //blink LED button is clicked. Send input to BlinkArduino method
        private void buttonBlink_Click(object sender, EventArgs e)
        {
            string name = textboxBlinks.Text;
            
            if(name == "1" || name == "2" || name == "3")
            {
                messageBox.Text = "LED Blinking... ";
                BlinkArduino(name, SerialPortBegin(getComPort()));
            }

            else
            {
                messageBox.Text = "Incorrect Input";
            }
            
        }

        //COM port is selected
        private void comboBoxAvailableComPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            //enable all buttons
            buttonBlink.Enabled = true;
            buttonReadVoltage.Enabled = true;
            LedON.Enabled = true;
            LedOFF.Enabled = true;
            buttonMotorOn.Enabled = true;
            buttonMotorOff.Enabled = true;

            //enable textboxes
            textboxBlinks.Enabled = true;
            textboxReadVoltage.Enabled = true;

            messageBox.Text = getComPort() + " Selected";
        }

        //Motor ON button is clicked
        private void buttonMotorOn_Click(object sender, EventArgs e)
        {
            messageBox.Text = "Motor Turned On";
            motorOn(SerialPortBegin(getComPort()));
        }

        //Motor OFF button is clicked
        private void buttonMotorOff_Click(object sender, EventArgs e)
        {
            messageBox.Text = "Turning Motor Off..";
            motorOff(SerialPortBegin(getComPort()));
        }
        //LED ON button is clicked
        private void LedON_Click(object sender, EventArgs e)
        {
            messageBox.Text = "Turning Red LED On..";
            redLedOn(SerialPortBegin(getComPort()));
        }

        //LED OFF button is clicked
        private void LedOFF_Click(object sender, EventArgs e)
        {
            messageBox.Text = "Turning Red LED Off..";
            redLedOff(SerialPortBegin(getComPort()));
        }

        //Voltage read button is clicked
        private void buttonReadVoltage_Click(object sender, EventArgs e)
        {
            messageBox.Text = "Reading Voltage..";
            readVoltage(SerialPortBegin(getComPort()));
        }


        //blinks the arduino once at a particular speed
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
            _serialPort.Close();

        }

        //turns the red LED on
        private void redLedOn(SerialPort _serialPort)
        {
            if (_serialPort.IsOpen)
            {
                _serialPort.Write("D");
                Thread.Sleep(200);
                _serialPort.Close();
            }
        }

        //turns the red LED off
        private void redLedOff(SerialPort _serialPort)
        {
            if (_serialPort.IsOpen)
            {
                _serialPort.Write("E");
                Thread.Sleep(200);
                _serialPort.Close();
            }
        }

        //turns the motor on
        private void motorOn(SerialPort _serialPort)
        {
            if (_serialPort.IsOpen)
            {
                _serialPort.Write("F");
                Thread.Sleep(200);
                _serialPort.Close();
            }
        }

        //turns the motor off
        private void motorOff(SerialPort _serialPort)
        {
            if (_serialPort.IsOpen)
            {
                _serialPort.Write("G");
                Thread.Sleep(200);
                _serialPort.Close();
            }
        }

        //reads the voltage input from the power supply
        private void readVoltage(SerialPort _serialPort)
        {

            if (_serialPort.IsOpen)
            {
                _serialPort.Write("H");

                Thread.Sleep(200);
                string voltageReading = _serialPort.ReadExisting();
                textboxReadVoltage.Text = voltageReading;

                _serialPort.Close();
            }
        }

        //opens serial communication from arduino to computer
        private SerialPort SerialPortBegin(string comPort)
        {
           
            SerialPort _serialPort = new SerialPort();
            _serialPort.PortName = comPort;
            _serialPort.BaudRate = 9600;

            try
            {
                _serialPort.Open();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Check to see if USB is connected");
            }
            return _serialPort;
        }

        //returns the name of the COM port selected from the dropdown
        private string getComPort()
        {
         string selectedComPort = comboBoxAvailableComPorts.SelectedItem.ToString();
         return selectedComPort;
        }

        private void buttonRefreshComPort_Click(object sender, EventArgs e)
        {
            string[] comPortArray = SerialPort.GetPortNames();
            comboBoxAvailableComPorts.Items.Clear();
            comboBoxAvailableComPorts.Items.AddRange(comPortArray);
            disableBoxes();
        }

        private void disableBoxes()
        {
            //disable all buttons (until COM port selected)
            buttonBlink.Enabled = false;
            buttonReadVoltage.Enabled = false;
            LedON.Enabled = false;
            LedOFF.Enabled = false;
            buttonMotorOn.Enabled = false;
            buttonMotorOff.Enabled = false;

            //disable textboxes (until COM port selected)
            textboxBlinks.Enabled = false;
            textboxReadVoltage.Enabled = false;

            messageBox.Text = "Select a COM Port";
        }
    }
}
