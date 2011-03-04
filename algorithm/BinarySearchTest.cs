using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace algorithm
{
    [TestClass]
    public class BinarySearchTest
    {
        [TestMethod]
        public void Search_One_Item()
        {
            int[] src = new int[]{1};

            Assert.AreEqual(BinarySearcher.Search(src, 1), 0);

            Assert.AreEqual(BinarySearcher.RecurseSearch(src, 1), 0);
        }

        [TestMethod]
        public void Search_One_Item_No_Match()
        {
            int[] src = new int[] { 1 };

            Assert.AreEqual(BinarySearcher.Search(src, 2), -1);

            Assert.AreEqual(BinarySearcher.RecurseSearch(src, 2), -1);
        }

        [TestMethod]
        public void Search_Two_Items()
        {
            int[] src = new int[]{1, 2};

            Assert.AreEqual(BinarySearcher.Search(src, 2), 1);
            Assert.AreEqual(BinarySearcher.RecurseSearch(src, 2), 1);
        }

        [TestMethod]
        public void Search_Two_Items_No_Match()
        {
            int[] src = new int[] { 1, 2 };

            Assert.AreEqual(BinarySearcher.Search(src, 3), -1);
            Assert.AreEqual(BinarySearcher.RecurseSearch(src, 3), -1);
        }

        [TestMethod]
        public void Search_Three_Items()
        {
            int[] src = new int[] { 1, 2,3 };

            Assert.AreEqual(BinarySearcher.Search(src, 2), 1);
            Assert.AreEqual(BinarySearcher.RecurseSearch(src, 2), 1);
        }

        [TestMethod]
        public void Search_Three_Items_No_Match()
        {
            int[] src = new int[] { 1, 2,3 };

            Assert.AreEqual(BinarySearcher.Search(src, 0), -1);
            Assert.AreEqual(BinarySearcher.RecurseSearch(src, 0), -1);
        }
    }
}
