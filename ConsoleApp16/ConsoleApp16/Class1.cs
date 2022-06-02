using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp16
{
    class Class1
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 10;
                int b = 0;
                int x = a / b;

            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Finally block executed");

            }
        }
    }
}
