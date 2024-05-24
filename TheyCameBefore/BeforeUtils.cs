using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheyCameBefore
{
    public static class BeforeUtils
    {
        public static IEnumerable<T> GetTheOnesBefore<T>(IEnumerable<T> items, T t) where T: IComparable<T>
        {
            List<T> outlist = new List<T>();
            foreach (T item in items)
            {
                if (item.CompareTo(t) < 0)
                {
                    outlist.Add(item);
                }
            }
            return outlist;
        }
    }
}