using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;

namespace InteractiveCalculator
{

    enum UserChoicesEnum
    {
        Add =  1,
        Subtract = 2,
        Multiply = 3,
        Divide = 4,
        Exit = 5
    }

    class Program
    {
        private static UserChoicesEnum GetUserChoice()
        {
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Exit");

            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
                return UserChoicesEnum.Add;
            if (choice == 2)
                return UserChoicesEnum.Subtract;
            if (choice == 3)
                return UserChoicesEnum.Multiply;
            if (choice == 4)
                return UserChoicesEnum.Divide;
            return UserChoicesEnum.Exit;
        }

        static void Main(string[] args)
        {
            var choice = UserChoicesEnum.Add;
            var calculator = new Calculator();
            
            var fileName = string.Format("calculator-{0}.dat" , DateTime.Now.ToString("hhmmss"));
            var calculatorWriter = new StreamWriter(fileName);
            var dataFormat = "{0},{1},{2},{3}";
            while (choice != UserChoicesEnum.Exit)
            {
                choice = GetUserChoice();   
                if (choice == UserChoicesEnum.Exit)
                    break;
                ReadNumbers(calculator);
                int result = calculator.Calculate(choice);
                var dataToWrite = string.Format(dataFormat, calculator.Number1, calculator.Number2, choice, result);
                calculatorWriter.WriteLine(dataToWrite);
                Console.WriteLine("Result = " + result);
            }
            calculatorWriter.Close();

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
