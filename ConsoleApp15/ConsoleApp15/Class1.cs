using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15
{
    class Class1
    {
        static void Main(string[] args)
        {
            // Declaring variable
            // without assigning value
            int G;

            // Pass variable to the method
            Sum(out G);

            // Display the value of G

            Console.WriteLine("The sum of" + "the value is: {0}", G);

            // Method in which out parameter is passed
            // and this method return the value of 
            // the passed parameter

            static void Sum(out int G)
            {
                G = 80;
                G= G+G;
            }


        }
    }
}
