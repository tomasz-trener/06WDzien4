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

            tj.jednWejsciowa = 'c';
            tj.jednDocelowa = 'g';

            double wynik =  tj.ZamienTemeprature(15);
        }
    }
}
