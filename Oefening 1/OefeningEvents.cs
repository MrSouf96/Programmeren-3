using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    public enum ProductType ( Tripel, Dubbel, Kriek, Pils );
    class OefeningEvents
    {
        public static void Main(String[] args)
        {

        }
    }
    
    public class Winkel
    {
        Winkel w = new Winkel();
        w.VerkoopProduct(new Bestelling(ProductType.Dubbel, 3.99, 35, "Dorpstraat 5, Lievegem");
        w.VerkoopProduct(new Bestelling(ProductType.Kriek, 3.99, 25, "Dorpstraat 5, Lievegem");
        w.VerkoopProduct(new Bestelling(ProductType.Dubbel, 3.99, 35, "Kerkstraat 155, Zele");
        w.VerkoopProduct(new Bestelling(ProductType.Kriek, 2.99, 55, "Dorpstraat 5, Lievegem");
        public void VerkoopProduct()
        {
            Console.WriteLine("----------");
            Console.WriteLine("Sales - rapport");
            Console.WriteLine(adres);
            Console.WriteLine(product "," aantal);
        }
    }
    public class Stockbeheer : Winkel
    {
        public int[] stock { get; set; }
        public int verkoopStock { get; set; }
        public int aanvullenStock { get; set; }

        public void stockVerkoop()
        {
            stock = 100;
         for(int index = 0; index.Length; index++)
            {
                stock[] = verkoopStock--;
            }
            
        }
        public void Stockaanvullen()
        {
            if(stock == 25)
                Console.WriteLine("Stock bijvullen");
        }
        public void tonenStock()
        {
        
        }

    }
    public class Sales : Stockbeheer
    {
    
    }
    public class Groothandelaar : Sales
    {
        public int[] lijst;

        for(int index = 0; index < lijst.Length; index++)
            {

            }

    }
    public class Bestelling : Groothandelaar
    {

        public double prijs { get; set; }
        public int aantal { get; set; }
        public string adres { get; set; }

        public Bestelling(ProductType _product, double _prijs, int _aantal, string _adres)
        {
            _product = product;
            _prijs = prijs;
            _aantal = aantal;
            _adres = adres;
        }
    }
}
