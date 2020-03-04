using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    public class ExtensionMethod
    {
        public static void Main(String[] args)
        {
            int num1 = 23453;
            int result = num1.GetDigits();
            Console.WriteLine(result);
        }
    }
    public class ExtensionMethodTwo : ExtensionMethod
    {
        public static int GetDigits(this int num)
        {
            int count = 0;
            while (num != 0)
            {
                count++;
                num = num / 10;
            }
            return count;
        }
    }
}
