using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Demo.MODEL;

namespace Demo.ListDemo
{
    public class Distinct:IEqualityComparer<Product>
    {
        #region IEqualityComparer<Product> 成员

        public bool Equals(Product x, Product y)
        {
            return x.Name == y.Name;
        }

        public int GetHashCode(Product obj)
        {
            return obj.Name.GetHashCode();
        }

        #endregion
    }
}
