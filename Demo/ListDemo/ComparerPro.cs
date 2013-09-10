using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Demo.MODEL;

namespace Demo.ListDemo
{
    public class ComparerPro
    {
        public List<Product> Check(List<Product> x, List<Product> y)
        {
            Comparer comparer = new Comparer();
            if (x.Count > y.Count)
                return x.Except(y, comparer).ToList<Product>();
            return y.Except(x, comparer).ToList<Product>();
        }
        public List<Product> Check2(List<Product> x, List<Product> y)
        {
            if (x.Count > y.Count)
                return x.Except(y).ToList();
            return y.Except(x).ToList();
        }
    }
}
