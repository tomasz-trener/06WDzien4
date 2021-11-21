using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09ZadanieZawodnicy
{
    class Program
    {
        static void Main(string[] args)
        {
            string sciezka = @"c:\dane\zawodnicy.txt";

            string[] dane = File.ReadAllLines(sciezka);

            Zawodnik[] zawodnicy = new Zawodnik[dane.Length];

            for (int i = 0; i < dane.Length; i++)
            {
                string[] komorki = dane[i].Split(';');
                Zawodnik z = new Zawodnik();
                z.Id_zawodnika = Convert.ToInt32(komorki[0]);
                z.Id_trenera = Convert.ToInt32(komorki[1]);
                z.Imie = komorki[2];
                z.Nazwisko = komorki[3];
                z.Kraj = komorki[4];
                z.DataUrodzenia = Convert.ToDateTime(komorki[5]);
                z.Wzrost = Convert.ToInt32(komorki[6]);
                z.Waga = Convert.ToInt32(komorki[7]);
                zawodnicy[i] = z;
            }
        }
    }
}
