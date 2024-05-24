using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace JustLikeACollection
{
    public class Guarda3<T> : IEnumerable<T>
    {
        
        private T t1;
        private T t2;
        private T t3;
        private T defVal;
        public Guarda3()
        {
            this.t1 = default;
            this.t2 = default;
            this.t3 = default;
            this.defVal = default;
        }
        public T GetItem(int i)
        {
            switch (i)
            {
                case 0:
                    return t1;
                case 1:
                    return t2;
                case 2:
                    return t3;
                default:
                    throw new IndexOutOfRangeException();

            }

        }
        public void SetItem(int i, T item)
        {
            switch (i)
            {
                case 0:
                    this.t1 = item;
                    break;
                case 1:
                    this.t2 = item;
                    break;
                case 2:
                    this.t3 = item;
                    break;
                default:
                    throw new IndexOutOfRangeException();

            }

        }

        //implement IEnumerable
        public IEnumerator <T> GetEnumerator()
        {
            List<T> list = new List<T>() { t1, t2, t3};
            for (int i = 0; i < 3; i++)
            {
                yield return list[i];
            }

        }
        IEnumerator IEnumerable.GetEnumerator ()
        {
            return GetEnumerator();
        }
        public void Add(T item)
        {
            List<T> list = new List<T>() { t1, t2, t3};            
            foreach (T i in list)
            {
                if ( Equals(i,default(T)))
                {
                    int index_ = list.IndexOf(i);
                    if (index_ == 0) t1 = item;
                    else if (index_ == 1) t2 = item;
                    else if (index_ == 2) t3 = item; 
                                     
                }
            }
            
        }
    }
}