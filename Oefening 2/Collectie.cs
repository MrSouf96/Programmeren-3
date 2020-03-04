using System;
using System.Collections.Generic;
using System.Text;

namespace Collecties
{
       
    public class Collecties
    {
        public static void Main(String[] args)
        {
            Schip vrachtschip = new Vrachtschip(27.5, 11.5, "Zeeland", 11);
            Schip roRoSchip = new RoRoSchip(28.5, 13.5, "RoRo", 11450, 13789);
            Schip containerSchip = new ContainerSchip(29.5, 15.5, "Raiko", 3500);
            Schip cruiseSchip = new CruiseSchip(550, 150, "Cruisy", 275);
            Dictionary<string, Schip> dictionarySchip = new Dictionary<int, Schip>();
            dictionarySchip.Add();
        }
    }
}
