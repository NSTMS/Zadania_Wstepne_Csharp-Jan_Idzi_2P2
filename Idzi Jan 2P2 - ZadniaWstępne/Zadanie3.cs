using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idzi_Jan_2P2___ZadniaWstępne
{
    class Zadanie3
    {

        public void solution()
        {
            /*
            Mając tekst, w którym dwa słowa pisane małymi literami są oddzielone dowolnym znakiem(zadbaj o poprawność danych!!!) 
            niebędącym literą, napisz metodę, która zmieni miejscami te dwa słowa.
            */
            Console.WriteLine();
            Console.WriteLine("----------------Zadanie 3--------------");

            Console.Write("Podaj tekst zawierający dwa słowa podzielone dowolnym znakiem(nie będącym literą): ");
            string tekst = Console.ReadLine();

            string pierwszy="";
            string drugi="";
            string znak="";

            for (int i=0; i<tekst.Length; i++)
            {
                if (char.IsLetter(tekst, i) == true)
                {
                    pierwszy = pierwszy + tekst[i];
                }
                else
                {
                    znak = tekst[i].ToString();
                    i += 1;

                    for (int j = i; j< tekst.Length; j++)
                    {
                        drugi = drugi + tekst[j];
                    }
                    break;
                }

            }

            Console.WriteLine("Zamieniony tekst: " + drugi + znak + pierwszy);

        }
    }
}
