using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P03WlasneKlasy
{
    class Program
    {
        static void Main(string[] args)
        {

            Kalkulator k = new Kalkulator();

            Kalkulator k2;

            // jeszcez nie moge korzystac z klakulatora bo go faktycznie ma 

            k2 = new Kalkulator();


            new Kalkulator();

            WebClient wc = new WebClient();

            int a = k.Dodaj(2, 3);

            int b = new Kalkulator().Odejmij(3, 4);

            k.Kolor = "czerwony";
            k2.Kolor = "niebieski";

            Czlowiek c = new Czlowiek();
            c.Imie = "Jan";
            c.Wzrost = 187;
            c.Wiek = 40;

            string s= c.Krzycz();


            WebClient wc2 = new WebClient();

            


             
        }
    }
}
