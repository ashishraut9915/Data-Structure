using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ArrayList_Programs
{
    internal class Remove_Element
    {
        public static void Main(String[] args)
        {
            ArrayList list = new ArrayList() { "Apple", "Banana", "Cherry", "Banana" };

            Console.WriteLine("Before Removing:");

            foreach(Object item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("After Removing:");
            list.Remove("Cherry");
            foreach (Object item in list)
            {
                Console.WriteLine(item);
            }

        }

    }
}
