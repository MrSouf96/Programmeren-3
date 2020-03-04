using System;
using System.Collections.Generic;
using System.Text;

namespace Collecties
{
    public class Vrachtschip : Schip
    {
        public int cargoWaarde { get; set; }


        public Vrachtschip(double _lengte, double _breedte, string _naam, int _cargowaarde) : base(_lengte, _breedte, _naam)
        {
            _lengte = lengte;
            _breedte = breedte;
            _naam = naam;
            _cargowaarde = cargoWaarde;
        }
    }
}
