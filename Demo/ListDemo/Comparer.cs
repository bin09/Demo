using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Demo.MODEL;

namespace Demo.ListDemo
{
    public class Comparer : IEqualityComparer<Product>
    {
        #region IEqualityComparer<Product> 成员

        public bool Equals(Product x, Product y)
        {
            // return ( x.Id == y.Id);                    //找出id不同的对象
            // return (x.Name==y.Name);             //找出name不同的对象

            return (x.Id == y.Id && x.Name == y.Name);            //找出id和name都不相同的对象
        }

        public int GetHashCode(Product obj)
        {
            // return obj.Id.GetHashCode();                 //比较属性，必须获取属性的hashcode
            // return obj.Name.GetHashCode();

            return (obj.Id+obj.Name).GetHashCode();          //多个属性必须获取每个属性的hashcode，不能直接获取obj的hashcode     
        }

        #endregion
    }
}
