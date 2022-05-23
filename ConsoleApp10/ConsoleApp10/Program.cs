using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {

            int weeknumber;
            Console.WriteLine("Enter the number from week number(1-7):");
            weeknumber = Convert.ToInt32(Console.ReadLine());
            switch(weeknumber)
            {
                case 1:
                Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednsday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("No choice match");
                    break;

            }
        }
    }
}
