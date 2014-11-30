using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionsOverview
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            Console.WriteLine("Total number of items in the list {0}", list.Count);
            for(var i=0;i<list.Count;i++)
                Console.WriteLine(list[i]);
            Console.ReadLine();


            var numberList = new NumberList();
            numberList.Add(10);
            numberList.Add(20);
            numberList.Add("abc");

            Console.WriteLine("Total # of numbers in the list = ", numberList.Count);

            Console.WriteLine("All the numbers in the list");
            for(var i=0;i<numberList.Count;i++)
                Console.WriteLine(numberList.Get(i));

            Console.WriteLine("Sum = ", numberList.Sum());
        }
    }
}
