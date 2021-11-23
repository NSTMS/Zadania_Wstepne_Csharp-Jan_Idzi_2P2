using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idzi_Jan_2P2___ZadniaWstępne
{
    class Zadanie11
    {
        public void solution()
        {
            Console.WriteLine("----------------------Zadanie 11-------------------");


            float a;
            float b;
            char znak = ' ';
            Console.WriteLine("Podaj pierwsza liczbe,znak działania oraz drugą liczbę: ");
            a = Convert.ToSingle(Console.ReadLine());
            znak = Convert.ToChar(Console.ReadLine());
            b = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine();

            switch (znak)
            {
                case '+':
                    {
                        Console.WriteLine(a);
                        Console.WriteLine("+");
                        Console.WriteLine(b);
                        Console.WriteLine("=");
                        Console.WriteLine(a+b);
                        break;
                    }
                case '-':
                    {
                        Console.WriteLine(a);
                        Console.WriteLine("-");
                        Console.WriteLine(b);
                        Console.WriteLine("=");
                        Console.WriteLine(a - b);
                        break;
                    } 
                case '*':
                    {
                        Console.WriteLine(a);
                        Console.WriteLine("*");
                        Console.WriteLine(b);
                        Console.WriteLine("=");
                        Console.WriteLine(a * b);
                        break;
                    }

                case '/':
                    {
                        Console.WriteLine(a);
                        Console.WriteLine("/");
                        Console.WriteLine(b);
                        Console.WriteLine("=");
                        Console.WriteLine(a / b);
                        break;
                    }
            }

            Console.WriteLine();

        }
    }
}
