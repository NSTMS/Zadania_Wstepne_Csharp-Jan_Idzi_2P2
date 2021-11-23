using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idzi_Jan_2P2___ZadniaWstępne
{
    class Zadanie2
    {
        public void solution()
        {

            /*
             Napisz metodę sprawdzającą, czy podana liczba (dodatnia liczba całkowita) zawiera cyfrę 3. 
             Nie konwertuj liczby na inny typ. 
             Nie używaj wbudowanych funkcji, takich jak Contains(), StartsWith(), itp. 
            */
            Console.WriteLine();
            Console.WriteLine("----------------Zadanie 2--------------");

            int liczba;
            Console.Write("Podaj liczbę: ");
            liczba = Convert.ToInt32(Console.ReadLine());
            liczba = Math.Abs(liczba);

            int cyfra = 0;
            int licz = 0;
                while (liczba > 0)
                {
                     cyfra = liczba % 10;
                     if(cyfra == 3){licz++;}

                liczba = liczba / 10;
                }
               
            if(licz > 0)
            {
               Console.WriteLine("Liczba zawiera w sobie 3");
            }else
            {
                Console.WriteLine("Liczba nie zawiera w sobie 3");
            }


        }
    }
}
