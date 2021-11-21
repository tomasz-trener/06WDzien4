using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08ZadanieKalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            KalkulatorUniwersalny ku = new KalkulatorUniwersalny(RodzajOperacji.Odjmowanie);

            int a = ku.WykonajOperacje(1, 6);
        }
    }
}
