using System;
using NUnit.Framework;

namespace TreeLib.Tests
{
    [TestFixture]
    public class GivenBTree
    {
        private static int[] data = new int[] { 1, 2, 3, 4, 5, 6 };
        private static BTree<int> tree;
        
        public class WhenBuildTreeFromData
        {
            [SetUp]
            public void Setup()
            {
                tree = new BTree<int>();
                tree.Import(data);
            }

            [Test]
            public void ThenTreeStateMustBeCorrect()
            {
                Console.WriteLine(tree.ToString());
            }
        }
    }
}