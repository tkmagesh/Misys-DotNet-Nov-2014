using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace IODemo
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter writer = new StreamWriter("myFile.txt");
            string data = "";
            while (data != "exit")
            {
                data = Console.ReadLine();
                if (data != "exit")
                    writer.WriteLine(data);
            }
            writer.Close();
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
