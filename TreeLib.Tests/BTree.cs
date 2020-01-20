using System;
using NUnit.Framework;

namespace TreeLib.Tests
{
    [TestFixture]
    public class BTreeTest
    {
        [Test]
        public void CreateBTReeFromArray()
        {
            var tree = new BTree<int, string>(3);

            for (int i = 0; i < 100; i++)
            {
                tree[i] = i.ToString();
            }

        }

    }
}