using System;
using System.Collections.Generic;
using System.Text;

namespace Segmenten
{
    class Segment
    {
        public Knoop beginKnoop { get; set; }
        public Knoop eindKnoop { get; set; }
        public int segmentID { get; set; }
        public List<Punt> vertices { get; set; }

        public virtual bool Equals(object)
        {

        }
        public virtual int GetHashCode()
        {
            return eindKnoop.GetHashCode() ^ beginKnoop.GetHashCode();
        }
        public Segment(int _segmentID, Knoop _beginKnoop, Knoop _eindKnoop, List<Punt> _vertices)
        {
            _segmentID = segmentID;
            _beginKnoop = beginKnoop;
            _eindKnoop = eindKnoop;
            _vertices = vertices;
        }
        public virtual string ToString()
        {

        }
    }
}
