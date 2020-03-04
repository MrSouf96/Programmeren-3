using System;
using System.Collections.Generic;
using System.Text;

namespace Segmenten
{
    class Knoop
    {
        public int knoopID { get; set; }
        public Punt punt { get; set; }

        public override bool Equals(Knoop)
        {

        }
        public override int GetHashCode()
        {
            return knoopID.GetHashCode ^ punt.GetHashCode;
        }
        public override string ToString()
        {

        }
        public Knoop(int _knoopID, Punt _punt)
        {
            _knoopID = knoopID;
            _punt = punt;
        }
    }
}
