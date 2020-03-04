using System;
using System.Collections.Generic;
using System.Text;

namespace Segmenten
{
    class Punt
    {
        public double x { get; set; }
        public double y { get; set; }

        public override bool Equals(object)
        {

        }
        public override int GetHashCode()
        {
            return x.GetHashCode ^ y.GetHashCode;
        }
        public Punt(double _x, double _y)
        {
            _x = x;
            _y = y;
        }
        public override string ToString()
        {

        }
    }
}
