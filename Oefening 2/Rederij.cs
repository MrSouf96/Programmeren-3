using System;
using System.Collections.Generic;
using System.Text;

namespace Collecties
{
    public class Rederij : Schip
    {
        public override string naam { get; set; }
        public int havens { get; set; }

        public Rederij(double _lengte, double _breedte, string _naam, int _havens) : base(_lengte, _breedte, _naam)
        {
            _lengte = lengte;
            _breedte = breedte;
            _naam = naam;
            _havens = havens;
        }

        public void totaleCargoWaarde()
        {
            Console.WriteLine();
        }
        public void geefHaven()
        {
            Console.WriteLine($"Er zijn {havens} havens aanwezig");
        }
        public void voegVlootToe(Vloot v)
        {
            Console.WriteLine(naam);
        }
        public void voegHavenToe(string naam)
        {
            Console.WriteLine(naam);
        }
        public void veranderVanVloot(string naam, string vloot)
        {
            Console.WriteLine(naam);
        }

    }
}
