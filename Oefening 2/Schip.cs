using System;
using System.Collections.Generic;
using System.Text;

namespace Collecties
{
    
    public abstract class Schip
    {
        public double lengte { get; set; }
        public double breedte { get; set; }
        public virtual string naam { get; set; }

        public Vloot Vloot { get; set; }
        public Schip Schip { get; set; }

        public Schip(double _lengte, double _breedte, string _naam)
        {
            _lengte = lengte;
            _breedte = breedte;
            _naam = naam;
        }

        //Bij Vloot en Schip een Dictionary gebruiken
        //lijst maken van schip
    }
}
