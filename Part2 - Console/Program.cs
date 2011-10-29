using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;

namespace Part2___Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] serialPorts = SerialPort.GetPortNames();

            Console.WriteLine("SerialComm in C Sharp, Part2 - Console");
            Console.WriteLine();
            Console.WriteLine("Select serial port:");

            if (serialPorts.Length == 0)
            {
                Console.WriteLine("-- no serial ports found!--");
                Environment.Exit(1);
            }

            for (int i = 0; i < serialPorts.Length; i++)
                Console.WriteLine(i + " - " + serialPorts[i]);

            Console.WriteLine();
            Console.Write("-> ");
            int choice = int.Parse(Console.ReadLine());

            SerialPort serialPort = new SerialPort(serialPorts[choice], 9600, Parity.None, 8, StopBits.One);
            try
            {
                serialPort.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("open() error: " + ex.Message);
                Environment.Exit(1);
            }
            serialPort.Write("Hello World!");
            serialPort.Close();
        }
    }
}
