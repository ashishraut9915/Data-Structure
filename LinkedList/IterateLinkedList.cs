using System;
using System.Collections.Generic;

class IterateLinkedList 
{
	static void Main()
	{
		LinkedList<int> linkedList = new LinkedList<int>();

		linkedList.AddLast(1);
		linkedList.AddLast(2);
		linkedList.AddLast(3);
		linkedList.AddLast(4);

		LinkedListNode<int> currentNode = linkedList.First;
		while (currentNode != null)
		{
			Console.WriteLine(currentNode.Value);
			currentNode = currentNode.Next;
		}
	}
}
