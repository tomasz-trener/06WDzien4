using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10ZadanieManagerZawodnikow
{
    class ManagerZawodnikow
    {
        public Zawodnik[] Zawodnicy;

        public void Wczytaj()
        {
            string sciezka = @"c:\dane\zawodnicy.txt";

            //string[] dane = File.ReadAllText(sciezka);
            string[] dane = File.ReadAllLines(sciezka);


            Zawodnicy = new Zawodnik[dane.Length];

            for (int i = 0; i < dane.Length; i++)
            {
                string[] komorki = dane[i].Split(';');
                Zawodnik z = new Zawodnik(komorki[2], komorki[3]);

                z.Id_zawodnika = Convert.ToInt32(komorki[0]);
                z.Id_trenera = Convert.ToInt32(komorki[1]);
                //z.Imie = komorki[2];
                //z.Nazwisko = komorki[3];
                z.Kraj = komorki[4];
                z.DataUrodzenia = Convert.ToDateTime(komorki[5]);
                z.Wzrost = Convert.ToInt32(komorki[6]);
                z.Waga = Convert.ToInt32(komorki[7]);
                Zawodnicy[i] = z;
            }

        }
    }
}
