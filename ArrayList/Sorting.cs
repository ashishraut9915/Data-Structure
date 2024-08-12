using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ArrayList_Programs
{
    internal class Sorting
    {
        public static void Main(String[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(5);
            list.Add(4);
            list.Add(2);
            list.Add(1);
            list.Add(6);

            list.Sort();

            foreach(Object item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
