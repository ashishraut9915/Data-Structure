using System;
using System.Collections;

namespace ArrayList_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ArrayList list = new ArrayList();

            list.Add("Ashish");
            list.Add(1);
            list.Add(3.14);
            list.Add(true);

            foreach(var item in list)
            {
                Console.WriteLine(item);
            }


        }
    }
}
