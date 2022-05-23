using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            int choice = 2;
            switch(choice)
            {
                case 1:
                    Console.WriteLine("The addition of two numbers"+a+b);
                    break;
                case 2:
                    Console.WriteLine("The subtraction of two numbers"+(a-b));
                    break;
                case 3:
                    Console.WriteLine("The division of two numbers"+(a/b));
                    break;
                default:
                    break;

            }

        }
    }
}
