using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04ZadanieTemperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            double tempC =15;

            TransformatorJednostek tj = new TransformatorJednostek();

            double wyn =tj.KonwertujCelKelv(tempC);
            Console.WriteLine(wyn);


            TransformatorJednostek2 tj2 = new TransformatorJednostek2();

            tj2.jednWejsciowa = 'c';
            tj2.jednDocelowa = 'f';

             double wyn2=  tj2.ZamienTemeprature(wyn);

            tj2.jednWejsciowa = 'k';

            wyn2 = tj2.ZamienTemeprature(wyn);

            Console.ReadKey();
        }
    }
}
