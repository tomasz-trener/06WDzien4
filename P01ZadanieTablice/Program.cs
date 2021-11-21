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

            //pobieramy dane z string . wszystko sziedzi jako string 
            string dane = new WebClient().DownloadString(url);
           
            // wiec muimsmy to splitowac po znakach nowej linii (\r\n)
            string[] wiersze= dane.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            //to otrzymamy tablice wiersy gzdie kazy element tej tablicy 
            // to bedzie jeden wiersz 

            // dla zwiekszenia czytelnosci oku towrze dodatkowe zmeinne ,
            // ktore wskauja na liczbe kol i libe wierszy 
            int liczbaKolumn = wiersze[0].Split(';').Length; // policzylem liczbe kol. na podstawie pierwszego weirsza (ale mozna wybrac dowolny wiersz bo oczywiscie liczba kolun jest stała)
            int liczbaWierszy = wiersze.Length - 1; // bazujac na wielkosci tyabcy wiersze i odejmujemy 1 bo nagłowenk 

            // wczytanie do tablicy duw wymiarowej 
            // przygotowujemy tablice tab1 do pracy 
            string[,] tab1 = new string[liczbaWierszy, liczbaKolumn];

            //idziemy po wszystkich wierszach 
            for (int i = 0; i < liczbaWierszy; i++)
            {    
                //wewnatrz i-tego wiersza dziiemy po wszystkich kolumnach 
                for (int j = 0; j < liczbaKolumn; j++)
                {
                    // rozbijamy i+1 (przsuniecie o nagłówk)  wiersz na komórki 
                    string[] tmp = wiersze[i + 1].Split(';');
                    // uzupełniamy komórkę i,j naszej tablicy o wartosć komórki j z temp
                    tab1[i, j] = tmp[j];
                }
            }


            // wczytywanie do tablicy tablic 

            // przygotowujemy tablice tablice (wiemy ile wierszy) 
            // nie okreslamy liczby kolumn bo ona zostanie okreslona na pozniejszym etapie 
            string[][] tab2 = new string[liczbaWierszy][];

            // idziemy po wwszystkich wierszach 
            for (int i = 0; i < liczbaWierszy; i++)
                tab2[i] = wiersze[i + 1].Split(';'); //rozbijamy i+1 wiersz na nową tablice i tę nową tabliće od razu przypisujmy do i pozycji tab2

            // wyswietlanie danych 

            // wyślietl tablcie dwu wymiarową (tab1)
            for (int i = 0; i < liczbaWierszy; i++)
            {
                for (int j = 0; j < liczbaKolumn; j++)
                {
                    Console.Write(tab1[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------");

            // wyswietl tablice tablic 
            for (int i = 0; i < liczbaWierszy; i++)
            {
                Console.WriteLine(string.Join(" " , tab2[i]));
            }


            Console.ReadKey();

        }
    }
}
