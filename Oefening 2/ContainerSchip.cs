using System;
using System.Collections.Generic;
using System.Text;

namespace Collecties

{
    public class ContainerSchip : Schip
    {
        public double capaciteit { get; set; }

        public ContainerSchip(double _lengte, double _breedte, string _naam, double _capaciteit) : base(_lengte, _breedte, _naam)
        {
            _lengte = lengte;
            _breedte = breedte;
            _naam = naam;
            _capaciteit = capaciteit;
        }
    }
}
