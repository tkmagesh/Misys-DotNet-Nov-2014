using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TypeDiscussion
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            Console.WriteLine("Before modifying, n = {0}", n);
            ModifyValue(ref n);
            Console.WriteLine("After modifying,  n = {0}", n);
            Console.ReadLine();
        }

        static void ModifyValue(ref int number)
        {
            number = 100;
        }
    }

    
}
