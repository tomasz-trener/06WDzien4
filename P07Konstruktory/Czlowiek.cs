using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07Konstruktory
{
    class Czlowiek
    {
        public string Imie;


        public Czlowiek(string imie)
        {
            Imie = imie;
        }

        public string PrzedstawSie()
        {
            return $"Nazywam się {Imie}";

        }
    }
}
