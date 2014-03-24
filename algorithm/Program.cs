using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace algorithm {
    class Program {
        static void Main(string[] args) {
            //EightQueens.BackTrack();
            //LinkedListTest();

            var bn = new BigNumber();
            var bytes = bn.Encode("12345");
            bn.PrintByteArray(bytes);
            //var numbers = bn.Decode(bytes);
            var a = bn.Add("1234", "54");
            var c = bn.Add("9999", "1");
            var d = bn.LongMultiple("12", "13");
            var e = bn.MultipleTwo("34567");
            var f = bn.DivideByTwo("1");
            var g = bn.PeasantMultiple("12", "13");
            Console.ReadKey();
        }

        static void LinkedListTest() {
            LinkedList<int> ll = new LinkedList<int>();
            ll.InsertAtFront(new LinkNode<int>(1));
            ll.InsertAtFront(new LinkNode<int>(2));
            ll.InsertAtEnd(new LinkNode<int>(3));

            Console.WriteLine(ll.ToString());

            foreach (int item in ll) {
                Console.WriteLine(item);
            }
        }
    }
}
