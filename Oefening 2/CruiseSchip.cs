using System;
using System.Collections.Generic;
using System.Text;

namespace Collecties
{
    public class CruiseSchip : Schip
    {
        public int aantalPassagiers { get; set; }

        public CruiseSchip(double _lengte, double _breedte, string _naam, int _aantalPassagiers) : base(_lengte, _breedte, _naam)
        {
            _lengte = lengte;
            _breedte = breedte;
            _naam = naam;
            _aantalPassagiers = aantalPassagiers;

        }
      
            
        
    }
}
