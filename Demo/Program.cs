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
            // List<Product> list = ComparerProduct();
           List<int> listEx=  Ex.ExSort(new List<int> { 2, 3, 4 });
           

            List<Product> list2 = ComparerDistinct();
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
            Product p3 = new Product() { Id = 1, Name = "tea" };
            y.Add(p3);

            return comparerPro.Check(x, y);
            //  return x.Except(y).ToList();
        }
        static List<Product> ComparerDistinct()
        {
            DistinctPro distinctPro = new DistinctPro();

            List<Product> x = new List<Product>();
            Product p1 = new Product() { Id = 1, Name = "tea" };
            Product p2 = new Product() { Id = 2, Name = "tea" };
            x.Add(p1);
            x.Add(p2);

            IEnumerable<Product> p = x.Where(value => { return value.Name == "tea"; });
            foreach (var item in p)
            {
                Product t = item;
            }
            Product p3 = x.Find((ss => { return ss.Name == "tea"; }));
            IEnumerable<Product> p4 = x.FindAll(t2 => { return t2.Name == "tea"; });

            return distinctPro.Check(x);

        }
    }
}
