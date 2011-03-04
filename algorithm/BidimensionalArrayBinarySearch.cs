using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace algorithm
{
    public static class BidimensionalArrayBinarySearcher
    {
        //有一个N*N的矩阵， 里面有N*N个数，这个矩阵的每一行，每一列都是排序好的，下面是一
        //个例子
        //1   3  7   9
        //2   5  13  14
        //6   8  25  26
        //20  24 30  40
        public static void Search(int[][] src, int subject, ref int row, ref int col)
        {
            Search(src, subject, 0, 0, src.Length, ref row, ref col);
        }
        private static void Search(int[][] src, int subject, int left, int top, int len, ref int row, ref int col)
        {
            if (src.Length > 0)
            {
                if (src.Length != src[0].Length) throw new ArgumentException("bad array!");
            }
            if (src.Length <= 0)
            {
                row = -1;col = -1;return;
            }
            if (len == 1)
            {
                if (src[top][left] == subject)
                {
                    row = top;col = left;return;
                }
                else
                {
                    row = -1;col = -1;return;
                }
            }

            if (src[src.Length - 1][src.Length - 1] < subject)
            {
                row = -1;col = -1;return;
            }


            // Seperate the array to 4 sub arrary
            int ulLeft, ulTop, ulLen, urLeft, urTop, urLen, llLeft, llTop, llLen, lrLeft, lrTop, lrLen;
            if ((len) % 2 == 0)
            {
                // Up Left Quadrant
                ulLeft = left;ulTop = top;ulLen = len / 2;

                // Up Right Quandrant
                urLeft = left + ulLen;urTop = top;urLen = len / 2;

                // Low Left Quadrant
                llLeft = left;llTop = top + ulLen;llLen = len / 2;

                //Low Right Quadrant
                lrLeft = left + ulLen;lrTop = top + ulLen;lrLen = len / 2;
            }
            else
            {
                // Up Left Quadrant
                ulLeft = left;ulTop = top;ulLen = len / 2 + 1;

                // Up Right Quandrant
                urLeft = left + ulLen;urTop = top;urLen = len / 2;

                // Low Left Quadrant
                llLeft = left;llTop = top + ulLen;llLen = len / 2;

                //Low Right Quadrant
                lrLeft = left + ulLen;lrTop = top + ulLen;lrLen = len / 2 + 1 ;
            }

            if (src[ulLeft + ulLen - 1][ulLeft + ulLen - 1] == subject)
            {
                row = ulLeft + ulLen - 1;col = ulLeft + ulLen - 1;return;
            }

            if (src[ulLeft + ulLen - 1][ulLeft + ulLen - 1] > subject)
            {
                // Search in Up Left Quandrant
                Search(src, subject, ulLeft, ulTop, ulLen, ref row, ref col);
            }
            else
            {
                // Search in Uper Right Quandrant
                Search(src, subject, urLeft, urTop, urLen, ref row, ref col);
                if (row == -1 && col == -1)
                {
                    // Search in Low Left Quandrant
                    Search(src, subject, llLeft, llTop, llLen, ref row, ref col);
                    if (row == -1 && col == -1)
                    {
                        // Search in Low Right Quandrant
                        Search(src, subject, lrLeft, lrTop, lrLen, ref row, ref col);
                    }
                    if (row == -1 && col == -1) return;
                }
            }

        }
    }

    public static class BinarySearcher
    {
        public static int Search(int[] src, int subject)
        {
            int low = 0, high = src.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (src[mid] < subject)
                {
                    low = mid + 1;
                }
                else if (src[mid] > subject)
                {
                    high = mid - 1;
                }
                else
                {
                    return mid;
                }
            }
            return -1;
        }

        public static int RecurseSearch(int[] src, int subject)
        {
            return RecurseSearch(src, subject, 0, src.Length - 1);
        }

        private static int RecurseSearch(int[] src, int subject, int low, int high)
        {
            int mid = (low + high) / 2;
            if (low > high) return -1;
            if (low == high)
            {
                if (src[mid] == subject) return mid;
            }
            if (src[mid] < subject)
            {
                return RecurseSearch(src, subject, mid + 1, high);
            }
            else if (src[mid] > subject)
            {
                return RecurseSearch(src, subject, low, mid - 1);
            }
            else
            {
                return mid;
            }

        }
    }
}
