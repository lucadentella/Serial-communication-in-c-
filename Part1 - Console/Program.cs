using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;

namespace Part1___Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] serialPorts = SerialPort.GetPortNames();

            Console.WriteLine("SerialComm in C Sharp, Part1 - Console");
            Console.WriteLine("Serial ports:");

            foreach (string serialPort in serialPorts)
                Console.WriteLine(serialPort);
        }
    }
}
