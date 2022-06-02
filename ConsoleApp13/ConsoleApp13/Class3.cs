using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    class Class3
    {
        static void Main(string[] args)
        {
            Queue qt = new Queue();
            qt.Enqueue("D");
            qt.Enqueue("E");
            qt.Enqueue("F");
            qt.Enqueue("G");
            qt.Dequeue();
            foreach(Object obj in qt)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("The number of elements in the Queue" + qt.Count);
           Console.WriteLine("Does the queue contain"+qt.Contains("E"));
            

        }
    }
}
