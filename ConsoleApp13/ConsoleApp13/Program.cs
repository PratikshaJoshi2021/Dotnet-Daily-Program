using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int row = 0; row <= 9; row++)
            {
                for(int col = 0; col <= 9; col++)
                {
                    if(row == 0 || col == 0 || row == 9 || col == 9 || row == col || col==9-row+1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
