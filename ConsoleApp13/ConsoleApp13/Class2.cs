using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    class Class2
    {
        public static void Main()
        {
            PropertiesInClass p = new PropertiesInClass(2.5);
            Console.WriteLine("Radius is " + p.radius);
            p.PrintCircumference();
            ;
        }
    }
}
