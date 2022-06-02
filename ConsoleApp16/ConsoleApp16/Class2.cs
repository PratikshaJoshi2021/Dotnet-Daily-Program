using System;
using System.Text;

namespace ConsoleApp16
{
    class Class2
    {
        static void Main(string[] args)
        {
            int a = 5, b = 10;
            Console.WriteLine("Before swap a=" + a + "b=" + b);
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("After swap a=" + a + "b=" + b);
        }
    }
}
