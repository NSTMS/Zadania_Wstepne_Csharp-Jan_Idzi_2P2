using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idzi_Jan_2P2___ZadniaWstępne
{
    class Zadanie13
    {
        public void solution()
        {
            Console.WriteLine();
            Console.WriteLine("----------------Zadanie 13--------------");

            TablicaZnakow();
        }
        void TablicaZnakow()
        {
            string tekst = " ", wynik="";

            do
            {
                Console.Write("Podaj dowolny tekst: ");
                tekst = Console.ReadLine();
            } while (tekst.Length > 30);

            for (int i = 0; i < tekst.Length; i++)
            {
                if (char.IsLetter(tekst, i) == true)
                {
                    wynik += tekst[i];
                }
            }
            Console.WriteLine($"Łańcuch znakowy(same litery) : {wynik}");
        }

    }
}
