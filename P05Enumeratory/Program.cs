using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05Enumeratory
{
    class Program
    {
        static void Main(string[] args)
        {
            TransformatorJednostek2 tj = new TransformatorJednostek2();

            tj.jw = Jednostka.Celcjusz;
            tj.jd = Jednostka.Farenheit;

            // po co stosujemy ernumeeratory ? 

            // czy ta klasa działa lepiej ? NIE
            // chodzi nam o to aby korzystanie z naszej klasy było wygodniejsze 
            // i barzdiej bezpieczne pod kątem np literówek 

            // GENERALNIE wiele rozwiązań z zakresu programowania obiektowego
            // nie ma na celu polepszenia działania naszego programu 
            // czyli program będzie działać tak samo dobrze

            // jednak stosowanie zasad programowa obiektowego
            // ma na celu zwiększenie czytelności kodu i polepszenie jakości kodu

            double wynik =  tj.ZamienTemeprature(15);
        }
    }
}
