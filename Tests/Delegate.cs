using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public delegate void Print(int value);
    public delegate void Copy(string waarde);
    public class Delegate
    {
        public static void Main(String[] args)
        {
            Print p = Add;
            p(10);

             Copy d = Ad;
            d("lol");
        }

        public static void Add(int value)
        {
            Console.WriteLine(value);
        }
        public static void Ad(string waarde)
        {
            Console.WriteLine(waarde);
        }
    }
}