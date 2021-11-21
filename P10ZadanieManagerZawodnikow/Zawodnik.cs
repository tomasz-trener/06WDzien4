using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10ZadanieManagerZawodnikow
{
    class Zawodnik
    {
        public int Id_zawodnika;
        public int Id_trenera;
        public string Imie;
        public string Nazwisko;
        public string Kraj;
        public DateTime DataUrodzenia;
        public int Wzrost;
        public int Waga;

        public Zawodnik(string imie, string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
        }

        public string PrzedstawSie()
        {
            return $"Nazywam {Imie} {Nazwisko} i pochodze z {Kraj}";
        }

    }
}
