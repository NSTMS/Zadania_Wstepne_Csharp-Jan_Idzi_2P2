using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idzi_Jan_2P2___ZadniaWstępne
{
    class Zadanie1_gwiazdka
    {

        public void solution()
        {
            /*
             Napiszę metodę, która pobiera użytkownika ciąg 10 liczb całkowitych,
            a następnie oblicza i wypisuje sumę oraz średnią tych liczb, które są podzielne przez 3 lub 5. 
             */
            Console.WriteLine();
            Console.WriteLine("----------------Zadanie 1 z gwiazdką--------------");

            int[] tab = new int[11];
            int wynik = 0;
            double srednia = 0.0;
            int iter = 0;

            for (int i=1; i <= 10; i++)
            {
                Console.Write("Wprowadź " + i + " liczbę: ");
                tab[i] =Convert.ToInt32(Console.ReadLine());
                
                if( tab[i] % 3  == 0  || tab[i] % 5 == 0)
                {
                    iter++;
                    wynik += tab[i];
                }
               
            }

            srednia = Convert.ToDouble(wynik / iter);

            Console.WriteLine("Suma podanych liczb, podzielnych przez 3 lub 5: " + wynik);
            Console.WriteLine("Srednia podanych liczb, podzielnych przez 3 lub 5: " + srednia);

        }
    }
}
