using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idzi_Jan_2P2___ZadniaWstępne
{
    class Zadanie5
    {
        public void solution()
        {
            /*
            Mając niepusty tekst, napisz metodę, która zwraca go w formacie skompresowanym.Przykładowe wejście i wyjście:
            "kkkktttrrrrrrrrrr" → "k4t3r10"
            "p555ppp7www" → "p153p371w3"
            */
            Console.WriteLine();
            Console.WriteLine("----------------Zadanie 5--------------");

            Console.Write("Wpisz tekst:");
            String tekst = Console.ReadLine();
            int i = 0;
            String kompres = "";
            int licznik = 0;
            char c;
            while (i < tekst.Length)
            {
                c = tekst[i];
                if (licznik == 0)
                {
                    licznik = 1;
                }
                if (i + 1 >= tekst.Length)
                {
                    kompres += (c + Convert.ToString(licznik));
                    licznik = 0;
                }
                else if (tekst[(i + 1)] == tekst[i])
                {
                    licznik += 1;
                }
                else
                {
                    kompres = kompres + (c + Convert.ToString(licznik));
                    licznik = 0;
                }
                i++;
            }
            Console.WriteLine(kompres);

        }




        /* string tekst ="";


        do{
            Console.Write("Wprowadz niepusty teskt: ");
            tekst = Console.ReadLine();
        } while (tekst == "") ;

        string[] litery = new string[tekst.Length-1];
        string litera="";

        for(int i=0; i<litery.Length;i++)
        {
            litera += tekst[i];
            litery[i] += litera;
            litera = "";
        }

        int iter = 1;
        int licz = 0;
        string wynikowa="";
        for (int i = 0; i <= litery.Length-1; i++)
            {
                    if (tekst[i] != tekst[i + 1])
                    {
                     wynikowa += litery[i] + iter;
                        iter = 1;
                    }
                    else
                    {
                        if (tekst[i-1] == tekst[litery.Length])
                        {
                            iter++;
                    licz = i;
                    }
                        else iter++;
                    }

            }
        wynikowa += litery[litery.Length-1] + iter;
        Console.WriteLine("Skompresowana forma wypowadzonego tekstu: " + wynikowa);
        }*/
    }

}
