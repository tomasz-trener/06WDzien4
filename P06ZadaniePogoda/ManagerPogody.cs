using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P06ZadaniePogoda
{
    class ManagerPogody
    {
        // znamy:
        // 1) pola  - do określenia cech obiektu (konfiguracji itp..)
        // 2) konstruktory - wymuszanie sposobu tworzenia obiektu
        // 3) metody - to wykonywania zadań

        public string NazwaMiasta;
        public Jednostka JednostkaTemeratury;


        public ManagerPogody(string nazwaMiasta, Jednostka jt)
        {
            NazwaMiasta = nazwaMiasta;
            JednostkaTemeratury = jt;
        }

        public double PodajTemperature()
        {
            string miasto = NazwaMiasta;

            //  string url = $"https://www.google.com/search?q=pogoda+{miasto}";
            string url = "https://www.google.com/search?q=pogoda+" + miasto;

            char znak = '°';

            string dane = new WebClient().DownloadString(url);

            // szuakmy pozycji tego znaku
            int idx = dane.IndexOf(znak);
            int aktualnyIdx = idx - 1;
            while (dane[aktualnyIdx] != '>')
                aktualnyIdx--;

            string wynik = dane.Substring(aktualnyIdx + 1, idx - aktualnyIdx + 1);

            double wynikDouble = Convert.ToInt32(wynik.Substring(0, wynik.Length - 2));

            TransformatorJednostek2 tj = new TransformatorJednostek2();
            tj.jw = Jednostka.Celcjusz;
            tj.jd = JednostkaTemeratury;


            return tj.ZamienTemeprature(wynikDouble); ;
        }

    }
}
