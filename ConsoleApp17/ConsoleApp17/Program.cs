﻿using System;
using System.Collections.Generic;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<String>();
            names.Add("S");
            names.Add("A");

            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
