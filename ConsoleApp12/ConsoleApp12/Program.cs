using System;

namespace ConsoleApp12
{
    class Program
    {
         public static void Main(string[] args)
        {
            int x = 6, y = 7;
            Console.Write(" ");
            for (x = 1; x <= 6; x++)
            {
                for (y = 1; y <= x; y++)
                {
                    if (x == 1 || x == 6 || y == 1 || y == 7)
                        Console.Write("*");
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
