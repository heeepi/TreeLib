using System;
using System.Collections;
using System.Collections.Generic;

namespace TreeLib
{
    public class BTreeNode<TKey> where TKey : IComparable
    {
        public TKey Key;
    }

    public class BTreeIndexNode<TKey, TValue> : BTreeNode<TKey> where TKey : IComparable
    {
        public IEnumerable<TValue> Values;
        public IEnumerable<BTreeNode<TKey>> Children;
    }

    public class BTreeValueNode<TKey, TValue> : BTreeNode<TKey> where TKey : IComparable
    {
        public TValue Value;
    }
}