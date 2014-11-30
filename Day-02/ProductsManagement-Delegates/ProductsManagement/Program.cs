using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductsManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            var productsList = new ProductsList();
            var product1 = new Product();
            product1.Id = 100;
            product1.Name = "Pen";
            product1.UnitCost = 10;
            product1.Units = 10;
            productsList.Add(product1);

            var product2 = new Product();
            product2.Id = 101;
            product2.Name = "Pencil";
            product2.UnitCost = 5;
            product2.Units = 10;
            productsList.Add(product2);

            var product3 = new Product();
            product3.Id = 100;
            product3.Name = "Pen";
            product3.UnitCost = 60;
            product3.Units = 10;
            productsList.Add(product3);

            var product4 = new Product();
            product4.Id = 101;
            product4.Name = "Pencil";
            product4.UnitCost = 70;
            product4.Units = 50;
            productsList.Add(product4);

            Console.WriteLine("List cost = {0}", productsList.CalculateCost(10));

            Console.WriteLine("All costly products");
            var costlyProducts = productsList.Filter(IsCostlyProduct);
            for (var i = 0; i < costlyProducts.Count; i++)
            {
                var costlyProduct = costlyProducts[i];
                Console.WriteLine("{0},{1},{2},{3}", costlyProduct.Id, costlyProduct.Name, costlyProduct.UnitCost, costlyProduct.Units);
            }
            Console.ReadLine();

        }

        public static bool IsCostlyProduct(Product product)
        {
            return product.UnitCost > 50;
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitCost { get; set; }
        public int Units { get; set; }
    }

    public class ProductsList
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
            get { return (Product) _list[index]; }
        }

        public decimal CalculateCost(decimal discount)
        {
            decimal total = 0;
            for (var i = 0; i < _list.Count; i++)
            {
                var product = (Product) _list[i];
                var productCost = product.UnitCost*product.Units;
                total += productCost;
            }
            var discountedTotal = total*((100 - discount)/100);
            return discountedTotal;
        }

        public ProductsList Filter(FilterProductDelegate filterProduct)
        {
            var result = new ProductsList();
            for (var i = 0; i < _list.Count; i++)
            {
                var product = (Product) _list[i];
                if (filterProduct(product))
                {
                    result.Add(product);
                }
            }
            return result;
        }
        
    }

    public delegate bool FilterProductDelegate(Product product);
}
