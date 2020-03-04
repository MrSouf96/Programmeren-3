using System;
using System.Collections.Generic;
using System.Text;

namespace Segmenten
{
    class Straat
    {
        public Graaf graaf { get; set; }
        public int straatID { get; set; }
        public string straatnaam { get; set; }

     public List<Knoop> getKnopen()
        {

        }
        public void showStraat()
        {
            Console.WriteLine();
        }
        public Straat(int _straatID, string _straatnaam, Graaf _graaf)
        {
            _straatID = straatID;
            _straatnaam = straatnaam;
            _graaf = graaf;
        }
    }
}