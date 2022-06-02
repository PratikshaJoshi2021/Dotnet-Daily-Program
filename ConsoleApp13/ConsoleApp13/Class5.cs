using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    class Person
    {
        public void Greet()
        {
            Console.WriteLine("Hello");
        }
        public void SetAge(int age)
        {
            age = 23;
            Console.WriteLine("Age of the person is:"+age);
        }
    }
    class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("I'm studying on the screen");
        }
        public void ShowAge()
        {
            Console.WriteLine("My age is: 23 years old");
        }
    }
    class Professor : Person
    {
        public void Explain()
        {
            Console.WriteLine("I am explaining");
        }
    }
    class StudentProfessorTest
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Greet();
            p.SetAge(23);
            Student s = new Student();
            s.ShowAge();
            s.Greet();
            Professor pf = new Professor();
            pf.SetAge(23);
            pf.Greet();
            pf.Explain();
            
        }
    }
}
