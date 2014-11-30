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
            //numberList.Add("abc");

            Console.WriteLine("Total # of numbers in the list = {0}", numberList.Count);

            Console.WriteLine("All the numbers in the list");
            for(var i=0;i<numberList.Count;i++)
                Console.WriteLine(numberList.Get(i));

            Console.WriteLine("Sum = {0}", numberList.Sum());
            Console.ReadLine();
        }
    }

    class NumberList
    {
        private ArrayList _list = new ArrayList();

        public void Add(int number)
        {
            _list.Add(number);
        }

        public int Count
        {
            get { return _list.Count; }
        }

        public int Get(int index)
        {
            return (int) _list[index];
        }

        public int Sum()
        {
            var result = 0;
            for (var i = 0; i < _list.Count; i++)
                result += (int) _list[i];
            return result;
        }
    }
}
