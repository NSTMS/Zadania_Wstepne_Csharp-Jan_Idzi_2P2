using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idzi_Jan_2P2___ZadniaWstępne
{
    class Zadanie12
    {
        public void solution()
        {
            Console.WriteLine();
            Console.WriteLine("----------------Zadanie 12--------------");

            Tablica();
        }
        void Tablica()
        {
            int n = 0;
            int parzysta = 0, nieparzysta = 0, ujemna = 0 , dodatnia = 0;

            do
            {
                Console.Write("Podaj wielkość tablicy: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 0);

            int[] tab = new int[n];
            Random random = new Random();
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                tab[i] = random.Next(-101, 101);
                if (tab[i] % 2 == 0) parzysta++;
                if (tab[i] % 2 != 0) nieparzysta++;
                if (tab[i] >= 0) dodatnia++;
                if (tab[i] < 0) ujemna++;
                
                Console.Write(tab[i] + ", ");
            }

            Console.WriteLine("\n\nWśród wylosowanych liczb jest: ");
            Console.WriteLine($"{parzysta} liczb parzystych");
            Console.WriteLine($"{nieparzysta} liczb nieparzystych");
            Console.WriteLine($"{dodatnia} liczb dodatnich");
            Console.WriteLine($"{ujemna} liczb ujemnych");


        }

    }
}
