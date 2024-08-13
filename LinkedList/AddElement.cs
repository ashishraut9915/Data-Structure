//Add Elements
using System;
using System.Collections.Generic;

class AddElements
{
    static void Main()
    {
        
        LinkedList<string> linkedList = new LinkedList<string>();

        linkedList.AddLast("Apple");
        linkedList.AddLast("Banana");
        linkedList.AddLast("Cherry");

        Console.WriteLine("Elements in the LinkedList:");
        foreach (var item in linkedList)
        {
            Console.WriteLine(item);
        }
    }
}
