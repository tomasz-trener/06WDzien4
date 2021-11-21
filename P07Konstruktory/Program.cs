using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07Konstruktory
{
    class Program
    {
        static void Main(string[] args)
        {
            Czlowiek c = new Czlowiek("jan");

            string s= c.PrzedstawSie();
        }
    }
}
