using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.ListDemo
{
    public static class Ex
    {
        /// <summary>
        /// 扩展方法
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static List<int> ExSort(this List<int> list)
        {
            List<int> myList = new List<int> { };
            list.Sort();
            foreach (var item in list)
            {
                if (item > 3)
                    myList.Add(item);
            }
            return myList;
        }
    }
}
