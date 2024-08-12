using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ArrayList_Programs
{
    internal class ConvertArrayListToArray
    {
        public static void Main(String[] args)
        {
            ArrayList list = new ArrayList() { "One", "Two", "Three", "Four" };


            object[] array = list.ToArray();


            Console.WriteLine("Array Elements:");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }      
}

