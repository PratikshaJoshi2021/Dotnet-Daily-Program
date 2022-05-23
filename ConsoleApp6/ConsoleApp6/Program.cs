using System;

public struct Student {
    public int rollno, marks;
    public string name;
}

public class TestStudent
{
    public static void Main()
    {
        Student s = new Student();
        s.rollno = 1;
        s.marks = 30;
        s.name = "ABC";
        Console.WriteLine("The rollno of Student" +s.rollno);
        Console.WriteLine("The marks of student" + s.marks);
        Console.WriteLine("The name of student" + s.name);



    }
}
