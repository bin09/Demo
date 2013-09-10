using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Demo.ListDemo;
using Demo.MODEL;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = ComparerProduct();
        }

        static List<Product> ComparerProduct()
        {
            ComparerPro comparerPro = new ComparerPro();

            List<Product> x = new List<Product>();
            Product p1 = new Product() { Id = 1, Name = "tea" };
            Product p2 = new Product() { Id = 2, Name = "cup" };
            x.Add(p1);
            x.Add(p2);

            List<Product> y = new List<Product>();
            Product p3 = new Product() { Id =1, Name = "tea" };
            y.Add(p3);

            return comparerPro.Check(x, y);
            //return x.Except(y).ToList();
        }
    }
}
