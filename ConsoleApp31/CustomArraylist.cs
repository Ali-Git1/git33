using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    public class CustomArraylist<T>
    {
        public T[] array;
        public int capacity;
        public int count;

        public int Capacity
        {
            get { return capacity; }
        }

        public int Count
        {
            get { return count; }
        }

        public CustomArraylist(int capacity)
        {
            this.capacity = capacity;
            array = new T[capacity];
            count = 0;
        }

        public void Add(T item)
        {
            if (Count == Capacity)
            {
                Array.Resize(ref array, capacity *= 2);
            }
            array[count++] = item;
        }

        public void TrimToSize()
        {
            if (Count < Capacity)
            {
                Array.Resize(ref array, count);
                capacity = count;
            }
        }

        public void Remove(object item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (object.Equals(array[i], item))
                {
                    RemoveAt(i);
                    break;
                }
            }
        }

        public void RemoveAt(int index)
        {
            while (index < Count - 1)
            {
                array[index] = array[index + 1];
                index++;
            }
            count--;
            array[Count] = default(T); 
        }

        public void AddRange(T[] collection)
        {
            foreach (var item in collection)
            {
                Add(item);
            }
        }
    }


}

