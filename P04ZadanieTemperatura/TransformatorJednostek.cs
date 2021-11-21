using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04ZadanieTemperatura
{
    class TransformatorJednostek
    {
        public double KonwertujCelKelv(double a)
        {
            return a +273.15;
        }

        public double KonwertujKelvCel(double a)
        {
            return a - 237.15;
        }

        public double KonwertujCelFar(double a)
        {
            return a * 1.8 + 32;
        }


        public double KonwertujFarCel(double a)
        {
            return (a - 32) / 1.8;
        }

        public double KonwertujFarKel(double a)
        {
            return (a - 32) / 1.8 + 273.15;
        }

        public double KonwertujKelFar(double a)
        {
            return (a - 273.15) * 1.8 + 32;
        }
    }
}
