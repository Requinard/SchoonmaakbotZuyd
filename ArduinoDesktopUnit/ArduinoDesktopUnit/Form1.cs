using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoDesktopUnit
{
    public delegate void UpdateControlDelegate (string data);

    public partial class Form1 : Form
    {
        private bool handIsOpen = false;

        public Form1()
        {
            InitializeComponent();

            serialPort1.Open();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string incomingTransmission = serialPort1.ReadLine();
            UpdateControlDelegate d = updateControls;
            this.Invoke(d, new object[] { incomingTransmission });
        }

        private void updateControls(string data)
        {
            richTextBox1.AppendText(data);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort1.ReadTimeout = -1;
            serialPort1.WriteTimeout = -1;
            serialPort1.DataReceived -= serialPort1_DataReceived;
            //serialPort1.Close();
        }

        public void WriteToSerial(string outgoingTransmission)
        {
            serialPort1.WriteLine(outgoingTransmission);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WriteToSerial("0");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            WriteToSerial("1");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WriteToSerial("2");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WriteToSerial("3");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WriteToSerial("4");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            WriteToSerial("5");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WriteToSerial("6");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            WriteToSerial("7");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (handIsOpen)
            {
                WriteToSerial("9");
                handIsOpen = true;
            }
            else
            {
                WriteToSerial("8");
                handIsOpen = false;
            }
        }
    }
}
