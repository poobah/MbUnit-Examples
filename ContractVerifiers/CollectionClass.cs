using System;
using System.Collections;
using System.Collections.Generic;

namespace ContractVerifiers
{
    internal class ClassCollection<T> : ICollection<T>
    {
        private List<T> items = new List<T>();

        protected void CheckItemNotNull(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
        }

        public virtual void Add(T item)
        {
            CheckItemNotNull(item);
            items.Add(item);
        }

        public virtual void Clear()
        {
            items.Clear();
        }

        public virtual bool Contains(T item)
        {
            CheckItemNotNull(item);
            return items.Contains(item);
        }

        public virtual void CopyTo(T[] array, int arrayIndex)
        {
            items.CopyTo(array, arrayIndex);
        }

        public virtual int Count
        {
            get
            {
                return items.Count;
            }
        }

        public virtual bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public virtual bool Remove(T item)
        {
            CheckItemNotNull(item);
            return items.Remove(item);
        }

        public virtual IEnumerator<T> GetEnumerator()
        {
            return items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (T item in items)
            {
                yield return item;
            }
        }
    }
}