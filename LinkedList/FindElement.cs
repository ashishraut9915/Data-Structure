using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedList
{
    internal class Program
    {
        static void Main()
        {
            LinkedList<string> linkedList = new LinkedList<string>();

            linkedList.AddLast("Apple");
            linkedList.AddLast("Banana");
            linkedList.AddLast("Cherry");

            LinkedListNode<string> node = linkedList.Find("Banana");

            if (node != null)
            {
                Console.WriteLine("Element found: " + node.Value);
            }
            else
            {
                Console.WriteLine("Element not found");
            }
        }
    }
}
