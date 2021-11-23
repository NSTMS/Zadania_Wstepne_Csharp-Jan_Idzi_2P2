using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idzi_Jan_2P2___ZadniaWstępne
{
    class Zadanie10
    {
        public void solution()
        {
            int n = 0;


            Console.WriteLine("------------Zadanie 10----------------");
                Console.Write("Podaj długość boku figury:  ");
                n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 | i == n - 1 | j == 0 | j == n - 1 | i == j | j == n - i - 1)
                    {
                        Console.Write("*");
                    }
                    else Console.Write(" ");

                    Console.Write(" ");
                }

                Console.WriteLine();

            }

        }
    }
}
