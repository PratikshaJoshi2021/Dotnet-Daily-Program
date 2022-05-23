using System;

public class EnumExample
{
    public enum Season {Winter, Summer, Spring, Fall}
    public static void Main()
    {
        int x = (int)Season.Summer;
        int y = (int)Season.Fall;
        Console.WriteLine("Summer = {0}", x);
        Console.WriteLine("Fall = {0}", y);
    }
}
