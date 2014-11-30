using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConstructorsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var productsList = new ProductsList();
            var product1 = new Product(100,"Pen",10,10);
            /*product1.Id = 100;
            product1.Name = "Pen";
            product1.UnitCost = 10;
            product1.Units = 10;*/
            productsList.Add(product1);

            var product2 = new Product(101, "Pencil", 5,10);
            /*product2.Id = 101;
            product2.Name = "Pencil";
            product2.UnitCost = 5;
            product2.Units = 10;*/
            productsList.Add(product2);

            Console.WriteLine("List cost = {0}", productsList.CalculateCost(10));
            Console.ReadLine();

        }
    }

    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitCost { get; set; }
        public int Units { get; set; }

        public Product(int id, string name, decimal unitCost, int units)
        {
            this.Id = id;
            this.Name = name;
            this.UnitCost = unitCost;
            this.Units = units;
        }
    }

    class ProductsList
    {
        private ArrayList _list = new ArrayList();
        public void Add(Product product)
        {
            _list.Add(product);
        }

        public int Count
        {
            get { return _list.Count; }
        }

        public void Remove(int index)
        {
            _list.Remove(index);


        }

        public Product this[int index]
        {
            get { return (Product)_list[index]; }
        }

        public decimal CalculateCost(decimal discount)
        {
            decimal total = 0;
            for (var i = 0; i < _list.Count; i++)
            {
                var product = (Product)_list[i];
                var productCost = product.UnitCost * product.Units;
                total += productCost;
            }
            var discountedTotal = total * ((100 - discount) / 100);
            return discountedTotal;
        }

    }
}
