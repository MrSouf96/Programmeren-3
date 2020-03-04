using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    class Func
    {
    // is a generic delegate
    // always one output 

    public static void Main(String[] args)
        {
            Func<int, int, int> obj = Add;
            obj(10, 10);
        }
        pubic static int Add(int x, int u)
        {
            return x + u;
        }
    }
}
