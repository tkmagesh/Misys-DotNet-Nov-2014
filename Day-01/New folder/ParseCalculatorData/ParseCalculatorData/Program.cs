using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ParseCalculatorData
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileName = "calculator-025526.dat";
            var reader = new StreamReader(fileName);
            var line = reader.ReadLine();
            while (line != null)
            {
                var data = line.Split(',');
                var number1 = int.Parse(data[0]);
                var operation = data[2];
                switch (operation)
                {
                        case ""
                }
            }
            reader.Close();
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
