using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnCollection
{
    public class ShortQueue<T> : ICollection<T>
    {
        private T[] innerCol;//use this to keep track of internal count
        public int Count => innerCol.Length;
        public bool IsReadOnly
        {
            get { return false; }//if you change state, its false. So always
        }
        //Init with 5 slots
        public ShortQueue()
        {
            innerCol = new T[5];
        }
        //init with costum slots
        public ShortQueue(int capacity)
        {
            innerCol = new T[capacity];
        }


        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}