using System;
using System.Collections.Generic;
using System.Text;
// Hashset
namespace ConsoleApp17
{
    class Class1
    {
        static void Main(string[] args)
        {
            var names = new HashSet<string>();
            names.Add("1");
            names.Add("2");
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
