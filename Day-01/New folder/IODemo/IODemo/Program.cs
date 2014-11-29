using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace IODemo
{
    enum UserChoicesEnum
    {
        Add = 1,
        Subtract = 2,
        Multiply = 3,
        Divide = 4,
        Exit = 5
    }
    class Program
    {
        static void Main(string[] args)
        {

            var data = "Add";
            var choice = (UserChoicesEnum) Enum.Parse(typeof (UserChoicesEnum), data);


            //Console.WriteLine("{0:c}", 1);
            Console.WriteLine(DateTime.Now.ToString("hhmmss"));
            Console.ReadLine();
            /* StreamWriter writer = new StreamWriter("myFile.txt");
            string data = "";
            while (data != "exit")
            {
                data = Console.ReadLine();
                if (data != "exit")
                    writer.WriteLine(data);
            }
            writer.Close();
            Console.WriteLine("Done");
            Console.ReadLine();*/
        }
    }
}
