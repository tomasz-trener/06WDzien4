using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06ZadaniePogoda
{
    class Program
    {
        static void Main(string[] args)
        {
            ManagerPogody mp = new ManagerPogody();
            mp.NazwaMiasta = "warszawa";
            mp.JednostkaTemeratury = Jednostka.Farenheit;

            double t= mp.PodajTemperature();


        }
    }
}
