using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new SalaryCalculator();
            calculator.Basic = 10000;
            calculator.Hra = 2000;
            calculator.Da = 3000;
            calculator.Tax = 10;
            Console.WriteLine("Salary = {0}", calculator.Calculate());
            Console.ReadLine();
        }
    }

    public class SalaryCalculator
    {
        private decimal _basic;

        public decimal Basic
        {
            get { return _basic; }
            set
            {
                if (_basic < 0 )
                    throw new Exception();
                _basic = value;
            }
        }

        private decimal _hra;

        public decimal Hra
        {
            get { return _hra; }
            set
            {
                if (_hra < 0)
                    throw new Exception();
                _hra = value;
            }
        }

        private decimal _da;
        public decimal Da
        {
            get { return _da; }
            set
            {
                if (_da < 0 )
                    throw new Exception();
                _da = value;
            }
        }

        private decimal _tax;

        public decimal Tax
        {
            get { return _tax; }
            set
            {
                if (_tax < 0 || _tax > 30)
                    throw new Exception();
                _tax = value;
            }
        }

        public decimal Calculate()
        {
            var gross = this.Basic + this.Hra + this.Da;
            var net = gross*((100 - this.Tax)/100);
            return net;
        }
    }

    class Employee
    {
        private int _id;

        public void SetId(int id)
        {
            if (id < 0)
                throw new ArgumentOutOfRangeException("id", "Id cannot be less than zero");
            _id = id;
        }

        public int GetId()
        {
            return _id;
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                if (value == string.Empty)
                    throw new ArgumentOutOfRangeException();
                _name = value;
            }
        }

        public decimal Salary;

        
    }
}
