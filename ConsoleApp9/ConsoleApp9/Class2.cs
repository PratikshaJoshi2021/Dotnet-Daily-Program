using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    class Class2
    {
        public static void mul()
        {
            int mul = 4 * 5;
            Console.WriteLine(mul);
        }
        public static void mul(int a, int b)
        {
            int mul = a * b;
            Console.WriteLine(mul);
        }
        public static void mul(int a, int b, int c)
        {
            int mul = a * b * c;
            Console.WriteLine(mul);
        }
        public static void mul(string a, string b)
        {
           int mul = Convert.ToInt32(a) + Convert.ToInt32(b);
            Console.WriteLine(mul);
        }
        public static void Main(string[] args)
        {
            mul();
            mul(22, 44);
            mul(23, 78, 66);
            mul("44", "77");
        }
    }
}
