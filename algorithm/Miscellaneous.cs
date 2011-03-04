using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace algorithm
{
    public static class Miscellaneous
    {

        public static int FabonacciRecurse(int n)
        {
            if (n == 1 || n == 2) return 1;

            return FabonacciRecurse(n - 1) + FabonacciRecurse(n - 2);
        }

        public static int FabonacciIteration(int n)
        {
            //int[] fa = new int[n+1];
            //fa[0] = fa[1] = 1;
            //for (int i = 2; i < n; i++)
            //{
            //    fa[i] = fa[i - 1] + fa[i - 2];
            //}

            //return fa[n - 1];
            int prev = 1, ret = 1;

            for (int i = 3; i <= n; i++)
            {
                int tmpRet = ret;
                ret += prev;
                prev = tmpRet;
            }

            return ret;
        }

        public static int FactorialRecurse(int n)
        {
            if (n == 1) return 1;

            return n*FactorialRecurse(n - 1);
        }

        public static int FactorialIteration(int n)
        {
            int ret = 1;

            for (int i = 2; i <= n; i++)
            {
                ret *=i;
            }

            return ret;
        }

        public static int FactorialStack(int n)
        {
            Stack<int> stack = new Stack<int>();
            int ret = 1;
            stack.Push(n);
            while (stack.Peek() > 1)
            {
                ret *= stack.Pop();
                stack.Push(n-=1);
            }

            return ret;
        }

        public static void Perm(int[] arr, int k)
        {
            var len = arr.Length;
            if (k == len - 1)
            {
                foreach (var i in arr)
                {
                    Console.Write("{0} ", i);
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = k; i < len; i++)
                {
                    Swap(ref arr[k], ref arr[i]);
                    Perm(arr, k + 1);
                    Swap(ref arr[k], ref arr[i]);
                }
            }
        }

        static void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
    }
}
