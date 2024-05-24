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
            innerCol.Clear();
        }

        public bool Contains(T item)
        {
            return innerCol.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            for (int i = arrayIndex; i > Count; i++)
            {
                array[i] = innerCol[i];
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            
            for (int i = 0; i < Count; i++)
            {
                yield return innerCol[i];
            }
        }

        public bool Remove(T item)
        {
            //remove item in case it exists
            //check instance numbers
            int numbOfItem = 0;
            if (Contains(item))
            {
                numbOfItem = innerCol.Count(i => i.Equals(item));
                //if more then one of item
                if (numbOfItem > 1)
                {
                    int indexToRemove = Count;
                    foreach (T itemToRemove in innerCol)
                    {
                        if (itemToRemove.Equals(item))
                        {
                            if(innerCol.IndexOf(itemToRemove) < indexToRemove)
                            {
                                indexToRemove = innerCol.IndexOf(itemToRemove);
                            }
                             
                        }
                        
                    }
                    innerCol.RemoveAt(indexToRemove);
                    return true;

                    
                } 
                else innerCol.RemoveAt(innerCol.IndexOf(item));
                return true;
            }
            else return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return  GetEnumerator();
        }
        
    }
}