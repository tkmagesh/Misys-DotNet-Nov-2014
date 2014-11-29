using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreetingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            
            string msg = "Hi " + name;
            Console.WriteLine(msg);
            Console.ReadLine();
        }

        
    }

   
}
