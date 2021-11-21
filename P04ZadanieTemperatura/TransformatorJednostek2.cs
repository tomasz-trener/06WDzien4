using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04ZadanieTemperatura
{
    class TransformatorJednostek2
    {
        public char jednWejsciowa;
        public char jednDocelowa;

        public double ZamienTemeprature(double temp)
        {
            string jw = jednWejsciowa.ToString().ToLower();
            string jd = jednDocelowa.ToString().ToLower();

            if (jw=="c" && jd=="f")
            {
                return temp * 1.8 + 32;
            }
            if (jw == "f" && jd == "c")
            {
                return (temp - 32) / 1.8;
            }

            if (jw == "c" && jd == "k")
            {
                return temp + 273.15;
            }
            if (jw == "k" && jd == "c")
            {
                return temp - 237.15;
            }

            if (jw == "f" && jd == "k")
            {
                return (temp - 32) / 1.8 + 273.15;
            }
            if (jw == "k" && jd == "f")
            {
                return (temp - 273.15) * 1.8 + 32;
            }

            throw new Exception("Podano niepoprawne dane wejściowe");


        }

    }
}
