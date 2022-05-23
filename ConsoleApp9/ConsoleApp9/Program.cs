using System;
// Instance Variable
namespace ConsoleApp9
{
    class Marks
    {
        int engMarks;
        int mathsMarks;
        public static void Main(string[] args)
        {
            Marks m = new Marks();
            m.engMarks = 60;
            m.mathsMarks = 70;
            Console.WriteLine("Marks for first object");
            Console.WriteLine(m.engMarks);
            Console.WriteLine(m.mathsMarks);
        }
    }
}
