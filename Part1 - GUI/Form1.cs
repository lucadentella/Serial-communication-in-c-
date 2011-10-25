using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace Part1___GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] comPorts = SerialPort.GetPortNames();
            
            foreach (string comPort in comPorts)
                cbSerialPort.Items.Add(comPort);

            if(comPorts.Length > 0)
                cbSerialPort.SelectedIndex = 0;
        }
    }
}