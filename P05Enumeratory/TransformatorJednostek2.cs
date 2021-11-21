using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05Enumeratory
{
    class TransformatorJednostek2
    {
        public Jednostka jw;
        public Jednostka jd;

        public double ZamienTemeprature(double temp)
        {
            if (jw==Jednostka.Celcjusz && jd==Jednostka.Farenheit)
            {
                return temp * 1.8 + 32;
            }
            if (jw == Jednostka.Farenheit && jd == Jednostka.Celcjusz)
            {
                return (temp - 32) / 1.8;
            }

            if (jw == Jednostka.Celcjusz && jd == Jednostka.Kelwin)
            {
                return temp + 273.15;
            }
            if (jw == Jednostka.Kelwin && jd == Jednostka.Celcjusz)
            {
                return temp - 237.15;
            }

            if (jw == Jednostka.Farenheit && jd == Jednostka.Kelwin)
            {
                return (temp - 32) / 1.8 + 273.15;
            }
            if (jw == Jednostka.Kelwin && jd == Jednostka.Farenheit)
            {
                return (temp - 273.15) * 1.8 + 32;
            }

            throw new Exception("Podano niepoprawne dane wejściowe");


        }

    }
}
