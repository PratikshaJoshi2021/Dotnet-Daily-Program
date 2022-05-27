using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp17
{
    class Class3
    {
        static void Main(string[] args)
        {
            var names = new SortedSet<string>();
            names.Add("E");
            names.Add("P");
            names.Add("A");
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }

        }
    }
}
