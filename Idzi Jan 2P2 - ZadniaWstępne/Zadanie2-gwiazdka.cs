using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idzi_Jan_2P2___ZadniaWstępne
{
    class Zadanie2_gwiazdka
    {
        public void solution()
        {

            /*
             Napisz metodę sprawdzającą, czy podana liczba (dodatnia liczba całkowita) zawiera cyfrę 3. 
             Nie konwertuj liczby na inny typ. 
             Nie używaj wbudowanych funkcji, takich jak Contains(), StartsWith(), itp. 
            */
            Console.WriteLine();
            Console.WriteLine("----------------Zadanie 2 z gwiazdką--------------");
            int liczba;
            Console.Write("Podaj liczbę: ");
            liczba = Convert.ToInt32(Console.ReadLine());
            if (Convert.ToString(liczba).Contains("3") == true)
            {
                Console.WriteLine("Liczba zawiera w sobie liczbę 3");
            }
            else Console.WriteLine("Liczba nie zawiera w sobie liczby 3");


        }

    }
}
