using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P01ZadanieTablice
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";

            string dane = new WebClient().DownloadString(url);

            string[] wiersze= dane.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            int liczbaKolumn = wiersze[0].Split(';').Length;
            int liczbaWierszy = wiersze.Length - 1;

            // wczytanie do tablicy tablic 
            string[,] tab1 = new string[liczbaWierszy, liczbaKolumn];

            for (int i = 0; i < liczbaWierszy; i++)
                for (int j = 0; j < liczbaKolumn; j++)
                {
                    string[] tmp = wiersze[i + 1].Split(';');
                    tab1[i, j] = tmp[j];
                }
            
            // 
        }
    }
}
