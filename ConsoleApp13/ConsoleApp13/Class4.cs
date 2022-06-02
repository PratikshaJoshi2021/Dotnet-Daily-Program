using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace ConsoleApp13
{
    class Class4
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("001", ".Net");
            ht.Add("002", "C#");
            ht.Add("003", "ASP.Net");
            ICollection keys = ht.Keys;
            foreach(String k in keys)
            {
                Console.WriteLine(ht[k]);
                Console.WriteLine(ht.ContainsKey("001"));
                Console.WriteLine(ht.ContainsValue("C#"));
            }
        }
    }
}
