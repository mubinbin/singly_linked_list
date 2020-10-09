using System;

namespace singly_linked_list
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList list1 = new SinglyLinkedList();
            list1.AddNode(4);
            list1.AddNode(5);
            list1.AddNode(1);
            list1.AddNode(90);
            list1.AddNode(-444);
            list1.AddNode(100);
            list1.AddNode(-11190);
            // list1.createLoop();
            // Console.WriteLine(list1.Head.Next);
            // list1.Remove();
            // list1.PrintValues();
            // list1.Reverse();
            Console.WriteLine(list1.HasLoop());
            list1.BreakLoop();
            Console.WriteLine(list1.HasLoop());
            // list1.PrintValues();
            // list1.Find(100);
            // list1.Find(-1);
            // list1.RemoveAt(0);
            // list1.RemoveAt(list1.ListSize()-1);
            // list1.RemoveAt(3);
            // list1.RemoveAt(-1);
        }
    }
}
