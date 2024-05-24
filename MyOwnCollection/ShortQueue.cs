using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnCollection
{
    public class ShortQueue<T> : ICollection<T>
    {
        private List<T> innerCol;//use this to keep track of internal count
        private int maxCap; //this number dictates how many items allowed int
        public int Count => innerCol.Count;
        public bool IsReadOnly
        {
            get { return false; }//if you change state, its false. So always
        }
        //Init with 5 slots
        public ShortQueue()
        {
            innerCol = new List<T>();
            maxCap = 5;
        }
        //init with input slots
        public ShortQueue(int capacity)
        {
            innerCol = new List<T>();
            maxCap = capacity;
        }
    
        public void Add(T item)
        {
            //if full
            if (Count == maxCap)
            {
                //First remove oldest (last index)
                innerCol.RemoveAt(innerCol.Count-1);
                //Adds new item
                innerCol.Add(item);
                
            }
            else innerCol.Add(item);
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