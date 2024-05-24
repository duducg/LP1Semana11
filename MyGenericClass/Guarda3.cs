using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGenericClass
{
    public class Guarda3<T>
    {
        private T t1;
        private T t2;
        private T t3;
        public Guarda3()
        {
            this.t1 = default;
            this.t2 = default;
            this.t3 = default;
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


    }
}