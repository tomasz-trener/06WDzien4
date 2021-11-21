using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10ZadanieManagerZawodnikow
{
    class Program
    {
        static void Main(string[] args)
        {
            ManagerZawodnikow mz = new ManagerZawodnikow();
            mz.Wczytaj();

            for (int i = 0; i < mz.Zawodnicy.Length; i++)
                Console.WriteLine(mz.Zawodnicy[i].PrzedstawSie());
            

            Console.ReadKey();
        }
    }
}
