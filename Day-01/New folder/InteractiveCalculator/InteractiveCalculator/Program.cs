using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mime;
using System.Text;

namespace InteractiveCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            while (choice < 5)
            {
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");

                choice = int.Parse(Console.ReadLine());
                if (choice > 4)
                    break;
                Console.WriteLine("Enter the number 1:");
                int number1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the number 2:");
                int number2 = int.Parse(Console.ReadLine());

                int result = 0;
                switch (choice)
                {
                    case  1 :
                        result = number1 + number2;
                        break;
                    case 2 :
                        result = number1 - number2;
                        break;
                    case 3 :
                        result = number1*number2;
                        break;
                    case 4 :
                        result = number1/number2;
                        break;
                }
                Console.WriteLine("Result = " + result);
            }

        }
    }
}
