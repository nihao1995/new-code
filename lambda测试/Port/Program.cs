using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;

namespace Port
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = System.IO.Ports.SerialPort.GetPortNames();
            foreach(var i in data)
            {
                Console.WriteLine(i);

            }
            Console.ReadLine();
        }
    }
}
