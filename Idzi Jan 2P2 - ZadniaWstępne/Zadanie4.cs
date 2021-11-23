using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idzi_Jan_2P2___ZadniaWstępne
{
    class Zadanie4
    {
        public void solution()
        {
            /*
                Mając liczbę nieujemną, napisz metodę, która zwraca jej cyfrowy pierwiastek.
                Z Wikipedii – pierwiastek cyfrowy to wartość uzyskana w iteracyjnym procesie sumowania cyfr, 
                przy każdej iteracji do obliczenia sumy cyfr wykorzystywany jest wynik z poprzedniej iteracji. 
                Proces jest kontynuowany aż do osiągnięcia jednocyfrowej liczby.
             */
            Console.WriteLine();
            Console.WriteLine("----------------Zadanie 4--------------");

            int liczba = 0;
            do {
                Console.Write("Podaj nieujemną liczbę: ");
                liczba = Convert.ToInt32(Console.ReadLine());
            } while (liczba < 0);

            int suma = 0;
            while (liczba != 0)
            {
                suma = suma + liczba % 10;
                liczba = liczba / 10;
            }

            suma = suma/10 + suma % 10;

            Console.WriteLine("Suma pierwiastka liczby to: " + suma);


        }

    }
}
