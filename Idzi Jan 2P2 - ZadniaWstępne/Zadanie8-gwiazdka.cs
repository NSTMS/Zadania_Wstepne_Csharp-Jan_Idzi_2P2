using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idzi_Jan_2P2___ZadniaWstępne
{
    class Zadanie8_gwiazdka
    {
        public void solution()
        {
            Console.WriteLine();
            Console.WriteLine("----------------Zadanie 8 z gwiazdką--------------");

            int n = 0;
            int k = 0;

                Console.Write("Podaj liczbę n: ");
                n = Convert.ToInt32(Console.ReadLine());

                Console.Write("Podaj liczbę k: ");
                k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Wartość dwumianu wynosi: " + dwumian(n,k));
        }

        static int dwumian(int n, int k)
        {
            if (n == 0 || n == k || k == 0)
            {
                return 1;
            }
            else
            {
                return dwumian(n - 1, k - 1) + dwumian(n - 1, k);
            }
        }


    }
}
