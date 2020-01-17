using System;
using System.Collections.Generic;

namespace TreeLib
{
    public abstract class BaseTree<TItem>
    {
        public abstract void Import(IEnumerable<TItem> data);

        public abstract TItem Find(Func<int, int> comparer);

        //public abstract void Add(TItem item);
        
        //public abstract void Delete(TItem item);
    }
}
