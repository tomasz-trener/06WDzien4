using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08ZadanieKalkulator
{

    enum RodzajOperacji
    {
        Dodanie,
        Odjmowanie,
        Mnozenie,
        Dzielenie,
      
    }
    class KalkulatorUniwersalny
    {
        public RodzajOperacji Ro;

        public KalkulatorUniwersalny(RodzajOperacji ro)
        {
            Ro = ro;
        }

        public int WykonajOperacje(int a, int b)
        {
            switch (Ro)
            {
                case RodzajOperacji.Dodanie:
                    return new KalkulatorDodajacy().Dodaj(a, b);
                case RodzajOperacji.Odjmowanie:
                    KalkulatorOdejmujacy k = new KalkulatorOdejmujacy();
                    return k.Odejmij(a, b);
                case RodzajOperacji.Mnozenie:
                    return new KalkulatorMnozenia().Pomnoz(a, b);
                case RodzajOperacji.Dzielenie:
                    return new KalkulatorDzielenia().Podziel(a, b);
                default:
                    throw new Exception("nieznany rodzaj operacji");
            }

            //if (ro == RodzajOperacji.Dodanie)
            //{
            //    return new KalkulatorDodajacy().Dodaj(a, b);
            //}
            //if (ro == RodzajOperacji.Odjmowanie)
            //{
            //    KalkulatorOdejmujacy k = new KalkulatorOdejmujacy();
            //    return k.Odejmij(a, b);
            //}
            //if (ro == RodzajOperacji.Mnozenie)
            //{
            //    return new KalkulatorMnozenia().Pomnoz(a, b);
            //}
            //if (ro == RodzajOperacji.Dzielenie)
            //{
            //    return new KalkulatorDzielenia().Podziel(a, b);
            //}

            throw new Exception("nieznany rodzaj operacji");
        }
    }
}
