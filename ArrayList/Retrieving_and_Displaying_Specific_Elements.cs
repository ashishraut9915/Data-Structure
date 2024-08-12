using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ArrayList_Programs
{
    internal class Retrieving_and_Displaying_Specific_Elements
    {
        public static void Main(String[]args)
        {
            ArrayList list = new ArrayList();
            list.Add("Ashish");
            list.Add("Chetan");
            list.Add("Parth");
            list.Add("Nikhil");
            list.Add("Bhushan");

            Console.WriteLine("First element: " + list[0]);
            Console.WriteLine("Last element: " + list[list.Count - 1]);

            foreach(Object item in list)
            {
                Console.WriteLine(item);
            }



        }
    }
}
