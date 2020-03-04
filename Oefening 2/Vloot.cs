using System;
using System.Collections.Generic;
using System.Text;

namespace Collecties
{
    public class Vloot : Schip
    {
        public override string naam { get; set; }

        public Vloot(double _lengte, double _breedte, string _naam) : base(_lengte, _breedte, _naam)
        {
            _lengte = lengte;
            _breedte = breedte;
            _naam = naam;
        }

        public void voegSchipToe(Schip schip)
        {   
            do
            {
                string[] schip;

                //Opvragen nieuw document:
                Console.Write("Nieuw schip: ");
                string nieuwSchip = Console.ReadLine();
                Console.WriteLine();

                //Invoegen nieuw document:
                schip[0] = nieuwSchip;

            } while (true);
            

        }
        public void verwijderSchip()
        {

        }
        public void zoekSchip()
        {
            string[] schip;

            do
            {
                Console.Write("Schip?: ");
                string opTeZoekenSchip = Console.ReadLine();

                int index = Array.BinarySearch(schip, opTeZoekenSchip);
                bool gevonden = (index >= 0);

                if (gevonden)
                    Console.WriteLine($"Schip: {schip[index]}");
                else
                    Console.WriteLine("Geen Schip teruggevonden met deze naam");

            } while (true);
        }
        public List<Schip> geefSchip()
        {
            string[] schip;
        foreach(string weergaveSchip in schip)
                Console.WriteLine(weergaveSchip + " ");
        }
        public void VeranderSchipVanVloot(string naam)
        {
         
        }
    }
}
