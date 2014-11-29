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
        static int GetUserChoice()
        {
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Exit");

            return int.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            int choice = 0;
            int number1 = 0, number2 = 0;
            Calculator calculator = new Calculator();

            while (choice < 5)
            {
                choice = GetUserChoice();   
                if (choice > 4)
                    break;
                ReadNumbers(calculator);
                int result = calculator.Calculate(choice);
                
                Console.WriteLine("Result = " + result);
            }

        }

        static void ReadNumbers(Calculator calculator)
        {
            Console.WriteLine("Enter the number 1:");
            calculator.Number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number 2:");
            calculator.Number2 = int.Parse(Console.ReadLine());
        }

       /* static int ProcessNumbers(int number1, int number2, int choice)
        {
            int result = 0;
            switch (choice)
            {
                case 1:
                    result = number1 + number2;
                    break;
                case 2:
                    result = number1 - number2;
                    break;
                case 3:
                    result = number1 * number2;
                    break;
                case 4:
                    result = number1 / number2;
                    break;
            }
            return result;
        }*/
    }
}
