using System;
using System.Collections.Generic;
using System.Text;

namespace Collecties
{
    public class RoRoSchip : Schip
    {
        public int nrAuto { get; set; }
        public int nrTruck { get; set; }

        public RoRoSchip(double _lengte, double _breedte, string _naam, int _nrAuto, int _nrTruck) : base(_lengte, _breedte, _naam)
        {
            _lengte = lengte;
            _breedte = breedte;
            _naam = naam;
            _nrAuto = nrAuto;
            _nrTruck = nrTruck;
        }
    }
}
