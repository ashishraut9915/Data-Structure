using System;
using System.Collections.Generic;

class RemovingElements
{
    static void Main()
    {
        LinkedList<string> linkedList = new LinkedList<string>();

        // Adding elements
        linkedList.AddLast("Apple");
        linkedList.AddLast("Banana");
        linkedList.AddLast("Cherry");

        // Removing the first element
        linkedList.RemoveFirst();

        // Removing a specific element
        linkedList.Remove("Banana");

        // Displaying the elements
        Console.WriteLine("LinkedList after removing elements:");
        foreach (var item in linkedList)
        {
            Console.WriteLine(item);
        }
    }
}
