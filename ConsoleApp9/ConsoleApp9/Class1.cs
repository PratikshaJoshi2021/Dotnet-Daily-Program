﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    class Class1
    {
        public static void sum()
        {
            int sum = 1 + 2;
            Console.WriteLine(sum);
        }

        public static void sum(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine(sum);
        }
        public static void sum(int a, int b, int c)
        {
            int sum = a + b + c;
            Console.WriteLine(sum);
        }
        public static void sum(string a, string b)
        {
            int sum = Convert.ToInt32(a) + Convert.ToInt32(b);
        }
        public static void Main(string[] args)
        {
            sum();
            sum(1, 2);
            sum(1, 2, 3);
            sum("2", "4");
        }
    }
}
