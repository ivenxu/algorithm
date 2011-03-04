using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListTest();
        }

        static void LinkedListTest()
        {
            LinkedList<int> ll = new LinkedList<int>();
            ll.InsertAtFront(new LinkNode<int>(1));
            ll.InsertAtFront(new LinkNode<int>(2));
            ll.InsertAtEnd(new LinkNode<int>(3));

            Console.WriteLine(ll.ToString());

            foreach (int item in ll)
            {
                Console.WriteLine(item);
            }
        }
    }
}
