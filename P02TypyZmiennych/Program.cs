using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P02TypyZmiennych
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            char b = 'x';
            string c = "napis";
            double d = 8.45;

            string e = "21-11-2021";

            DateTime dt = new DateTime(2021, 11, 21);

            WebClient wc = new WebClient();

            StringBuilder sb = new StringBuilder("ala");
            sb.Append(" ma");
            sb.Append(" kota");
            string s = sb.ToString();
            
        }
    }
}
