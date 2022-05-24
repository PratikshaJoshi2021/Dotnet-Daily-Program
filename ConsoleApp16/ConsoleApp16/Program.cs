using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 3, 4, 2 };
            Console.WriteLine("Duplicate array elements are:");
            for(int i=0; i<arr.Length;i++)
            {
                for(int j=i+1; j<arr.Length;j++)
                {
                    if (arr[i] == arr[j])
                        Console.WriteLine(arr[j]);
                }
            }
        }
    }
}
