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

        public int Calculate(UserChoicesEnum choice)
        {
            var result = 0;
            switch (choice)
            {
                case UserChoicesEnum.Add:
                    result = Add();
                    break;
                case UserChoicesEnum.Subtract:
                    result = Subtract();
                    break;
                case UserChoicesEnum.Multiply:
                    result = Multiply();
                    break;
                case UserChoicesEnum.Divide:
                    result = Divide();
                    break;
            }
            return result;
        }
    }
}
