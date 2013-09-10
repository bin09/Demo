using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Demo.MODEL;

namespace Demo.ListDemo
{
   public  class DistinctPro
    {
       public List<Product> Check(List<Product> list)
       {
           Distinct comparer=new Distinct();
               return list.Distinct(comparer).ToList();
       }
    }
}
