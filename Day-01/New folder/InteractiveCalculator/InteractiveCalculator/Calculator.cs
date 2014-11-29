using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InteractiveCalculator
{
    class Calculator
    {
        public int Number1;
        public int Number2;

        public int Add()
        {
            return Number1 + Number2;
        }

        public int Subtract()
        {
            return Number1 - Number2;
        }

        public int Multiply()
        {
            return Number1 * Number2;
        }

        public int Divide()
        {
            return Number1 / Number2;
        }

        public int Calculate(int choice)
        {
            var result = 0;
            switch (choice)
            {
                case 1:
                    result = Add();
                    break;
                case 2:
                    result = Subtract();
                    break;
                case 3:
                    result = Multiply();
                    break;
                case 4:
                    result = Divide();
                    break;
            }
            return result;
        }
    }
}
