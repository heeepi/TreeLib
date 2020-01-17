using System;
using System.Collections.Generic;

namespace TreeLib
{
    public class BTree<TItem> : BaseTree<TItem>
    {
        public override TItem Find(Func<int, int> comparer)
        {
            throw new NotImplementedException();
        }

        public override void Import(IEnumerable<TItem> data)
        {
            foreach (var item in data)
            {
                
            }
        }
    }
}
