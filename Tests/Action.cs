using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    class Action
    {
        //doesn't return a value
         public static void Main(String[] args)
        {
            Action<int> actie1 = Ride;
            actie1(9);
        }
        public static void Ride(int value)
        {
            Console.WriteLine(value);
        }
    }
}
