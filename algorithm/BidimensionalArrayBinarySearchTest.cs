using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace algorithm
{
    [TestClass]
    public class BidimensionalArrayBinarySearchTest
    {
        [TestMethod]
        public void Empty_Array_Test()
        {
            int[][] src = new int[][]{};

            int row =0, col=0;
            BidimensionalArrayBinarySearcher.Search(src, 1, ref row, ref col);
            Assert.AreEqual(row, -1);
            Assert.AreEqual(col, -1);
        }

        [TestMethod]
        public void One_Item_Match()
        {
            int[][] src = new int[][]{new [] {1}};
            int row = 0, col = 0;
            BidimensionalArrayBinarySearcher.Search(src, 1, ref row, ref col);
            Assert.AreEqual(row, 0);
            Assert.AreEqual(col, 0);
        }

        [TestMethod]
        public void One_Item_No_Match()
        {
            int[][] src = new int[][] { new[] { 1 } };
            int row = 0, col = 0;
            BidimensionalArrayBinarySearcher.Search(src, 2, ref row, ref col);
            Assert.AreEqual(row, -1);
            Assert.AreEqual(col, -1);
        }

        [TestMethod]
        public void Two_Rows_Two_Cols_No_Match()
        {
            int[][] src = new int[][] { new[] { 1, 3 }, new[] { 2, 5 } };
            int row = 0, col = 0;
            BidimensionalArrayBinarySearcher.Search(src, 4, ref row, ref col);
            Assert.AreEqual(row, -1);
            Assert.AreEqual(col, -1);
        }

        [TestMethod]
        public void Two_Rows_Two_Cols_Match_In_First_Row()
        {
            int[][] src = new int[][] { new[] { 1,3 }, new []{2,5}  };
            int row = 0, col = 0;
            BidimensionalArrayBinarySearcher.Search(src, 3, ref row, ref col);
            Assert.AreEqual(row, 0);
            Assert.AreEqual(col, 1);
        }

        [TestMethod]
        public void Two_Rows_Two_Cols_Match_In_Second_Row()
        {
            int[][] src = new int[][] { new[] { 1, 3 }, new[] { 2, 5 } };
            int row = 0, col = 0;
            BidimensionalArrayBinarySearcher.Search(src, 2, ref row, ref col);
            Assert.AreEqual(row, 1);
            Assert.AreEqual(col, 0);
        }

        [TestMethod]
        public void Three_Rows_Three_Cols_No_Match()
        {
            int[][] src = new int[][] { new[] { 1, 3 ,7}, new[] { 2, 4, 8}, new int[]{5, 6, 10}  };
            int row = 0, col = 0;
            BidimensionalArrayBinarySearcher.Search(src, 9, ref row, ref col);
            Assert.AreEqual(row, -1);
            Assert.AreEqual(col, -1);
        }

        [TestMethod]
        public void Three_Rows_Three_Cols_Match_In_Top_Left_Quandrant()
        {
            int[][] src = new int[][] { new[] { 1, 3, 7 }, new[] { 2, 4, 8 }, new int[] { 5, 6, 10 } };
            int row = 0, col = 0;
            BidimensionalArrayBinarySearcher.Search(src, 3, ref row, ref col);
            Assert.AreEqual(row, 0);
            Assert.AreEqual(col, 1);
        }

        [TestMethod]
        public void Three_Rows_Three_Cols_Match_In_Top_Left_Quandrant_Mid()
        {
            int[][] src = new int[][] { new[] { 1, 3, 7 }, new[] { 2, 4, 8 }, new int[] { 5, 6, 10 } };
            int row = 0, col = 0;
            BidimensionalArrayBinarySearcher.Search(src, 4, ref row, ref col);
            Assert.AreEqual(row, 1);
            Assert.AreEqual(col, 1);
        }

        [TestMethod]
        public void Three_Rows_Three_Cols_Match_In_Top_Right_Quandrant()
        {
            int[][] src = new int[][] { new[] { 1, 3, 7 }, new[] { 2, 4, 8 }, new int[] { 5, 6, 10 } };
            int row = 0, col = 0;
            BidimensionalArrayBinarySearcher.Search(src, 7, ref row, ref col);
            Assert.AreEqual(row, 0);
            Assert.AreEqual(col, 2);
        }

        [TestMethod]
        public void Three_Rows_Three_Cols_Match_In_Low_Left_Quandrant()
        {
            int[][] src = new int[][] { new[] { 1, 3, 7 }, new[] { 2, 4, 8 }, new int[] { 5, 6, 10 } };
            int row = 0, col = 0;
            BidimensionalArrayBinarySearcher.Search(src, 5, ref row, ref col);
            Assert.AreEqual(row, 2);
            Assert.AreEqual(col, 0);
        }

        [TestMethod]
        public void Three_Rows_Three_Cols_Match_In_Low_Right_Quandrant()
        {
            int[][] src = new int[][] { new[] { 1, 3, 7 }, new[] { 2, 4, 8 }, new int[] { 5, 6, 10 } };
            int row = 0, col = 0;
            BidimensionalArrayBinarySearcher.Search(src, 10, ref row, ref col);
            Assert.AreEqual(row, 2);
            Assert.AreEqual(col, 2);
        }

        [TestMethod]
        public void Four_Rows_Four_Cols_No_Match()
        {
            int[][] src = new int[][] { new[] { 1, 5, 9, 13 }, new[] { 2, 6, 10, 14 }, new int[] { 3, 7, 11, 14 }, new int[]{4, 8, 12, 16}  };
            int row = 0, col = 0;
            BidimensionalArrayBinarySearcher.Search(src, 0, ref row, ref col);
            Assert.AreEqual(row, -1);
            Assert.AreEqual(col, -1);
        }

        [TestMethod]
        public void Four_Rows_Four_Cols_Top_Left_Quandrant()
        {
            int[][] src = new int[][] { new[] { 1, 5, 9, 13 }, new[] { 2, 6, 10, 14 }, new int[] { 3, 7, 11, 14 }, new int[] { 4, 8, 12, 16 } };
            int row = 0, col = 0;
            BidimensionalArrayBinarySearcher.Search(src, 5, ref row, ref col);
            Assert.AreEqual(row, 0);
            Assert.AreEqual(col, 1);
        }

        [TestMethod]
        public void Four_Rows_Four_Cols_Top_Left_Quandrant_Mid()
        {
            int[][] src = new int[][] { new[] { 1, 5, 9, 13 }, new[] { 2, 6, 10, 14 }, new int[] { 3, 7, 11, 14 }, new int[] { 4, 8, 12, 16 } };
            int row = 0, col = 0;
            BidimensionalArrayBinarySearcher.Search(src, 6, ref row, ref col);
            Assert.AreEqual(row, 1);
            Assert.AreEqual(col, 1);
        }

        [TestMethod]
        public void Four_Rows_Four_Cols_Top_Right_Quandrant()
        {
            int[][] src = new int[][] { new[] { 1, 5, 9, 13 }, new[] { 2, 6, 10, 14 }, new int[] { 3, 7, 11, 14 }, new int[] { 4, 8, 12, 16 } };
            int row = 0, col = 0;
            BidimensionalArrayBinarySearcher.Search(src, 13, ref row, ref col);
            Assert.AreEqual(row, 0);
            Assert.AreEqual(col, 3);
        }

        [TestMethod]
        public void Four_Rows_Four_Cols_Low_Left_Quandrant()
        {
            int[][] src = new int[][] { new[] { 1, 5, 9, 13 }, new[] { 2, 6, 10, 14 }, new int[] { 3, 7, 11, 14 }, new int[] { 4, 8, 12, 16 } };
            int row = 0, col = 0;
            BidimensionalArrayBinarySearcher.Search(src, 7, ref row, ref col);
            Assert.AreEqual(row, 2);
            Assert.AreEqual(col, 1);
        }

        [TestMethod]
        public void Four_Rows_Four_Cols_Low_Right_Quandrant()
        {
            int[][] src = new int[][] { new[] { 1, 5, 9, 13 }, new[] { 2, 6, 10, 14 }, new int[] { 3, 7, 11, 14 }, new int[] { 4, 8, 12, 16 } };
            int row = 0, col = 0;
            BidimensionalArrayBinarySearcher.Search(src, 12, ref row, ref col);
            Assert.AreEqual(row, 3);
            Assert.AreEqual(col, 2);
        }

        [TestMethod]
        public void Four_Rows_Four_Cols_Secial_Case()
        {
            int[][] src = new int[][] { new[] { 1, 3, 7, 9 }, new[] { 2, 5,13,14 }, new int[] { 6,8,25,26 }, new int[] { 20,24,30,40 } };
            int row = 0, col = 0;
            BidimensionalArrayBinarySearcher.Search(src, 24, ref row, ref col);
            Assert.AreEqual(row, 3);
            Assert.AreEqual(col, 1);
        }
    }
}
