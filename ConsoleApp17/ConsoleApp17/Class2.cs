using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp17
{
    class Class2
    {
        static void Main(string[] args)
        {
            var names = new HashSet<string>() { "A", "B", "C" };
            foreach(var name in names)
            {
                Console.WriteLine(names);
            }

        }
    }
}
