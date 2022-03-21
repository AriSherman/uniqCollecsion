using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueICollection
{
    internal class uniqCollecsion<T> : ICollection<T>
    {
        List<T> Name = new List<T>();


        public int Count => Name.Count;

        public bool IsReadOnly => false;

        public void Add(T item)
        {
            if (!Contains(item))
                Name.Add(item);
        }

        public void Clear()
        {
            Name.Clear();
        }

        public bool Contains(T item)
        {
            return Name.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            foreach (T item in Name)
            {
                array[arrayIndex++] = item;
            };
        }

        public IEnumerator<T> GetEnumerator()
        {
            return Name.GetEnumerator();
        }
        public bool Remove(T item)
        {
            return Name.Remove(item);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
