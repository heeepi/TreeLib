using System;
using System.Collections;
using System.Collections.Generic;

namespace TreeLib
{
    public class BTree<TKey, TValue> : IDictionary<TKey, TValue> where TKey : IComparable
    {
        private int degree;

        private BTreeIndexNode<TKey, TValue> root;

        public BTree(int degree = 3)
        {
            this.degree = degree;
            this.root = new BTreeIndexNode<TKey, TValue>();
        }

        public TValue this[TKey key]
        {
            get
            {
                if (this.TryGetValue(key, out TValue value)) return value;
                throw new KeyNotFoundException();
            }
            set
            {
                this.Add(key, value);
            }
        }

        public ICollection<TKey> Keys => throw new NotImplementedException();

        public ICollection<TValue> Values => throw new NotImplementedException();

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(TKey key, TValue value)
        {
            throw new NotImplementedException();
        }

        public void Add(KeyValuePair<TKey, TValue> item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            throw new NotImplementedException();
        }

        public bool ContainsKey(TKey key)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(TKey key)
        {
            throw new NotImplementedException();
        }

        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            return this.Remove(item.Key);
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
