using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    class EqualsMethod
    {
        public static void Main(String[] args)
        {
            int i = 10;
            int j = 10;

            //first way to check if its Equal
            Console.WriteLine(i == j);
            //
            Console.WriteLine(i.Equals(j));
        }
    }
}