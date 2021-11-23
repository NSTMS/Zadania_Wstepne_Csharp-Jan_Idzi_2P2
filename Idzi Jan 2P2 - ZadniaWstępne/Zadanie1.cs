using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idzi_Jan_2P2___ZadniaWstępne
{
    class Zadanie1
    {
        public void solution()
        {
            /*
              Napisz metodę, która wczytuje liczbę typu decimal (zwiększonej precyzji) 
              oraz liczbę rzeczywistą pojedynczej precyzji i wypisuje wynik operacji dodawania,
              odejmowania, mnożenia oraz dzielenia tych liczb z dokładnością do dwóch miejsc po przecinku.
             */
            Console.WriteLine();
            Console.WriteLine("----------------Zadanie 1--------------");

            double l1;
            Single l2;

            Console.Write("Wprowadź pierwszą liczbę: ");
            l1 =  Convert.ToDouble(Console.ReadLine());

            Console.Write("Wprowadź drugą liczbę: ");
            l2 = Convert.ToSingle(Console.ReadLine());

            double wynik;

            NumberFormatInfo setPrecision = new NumberFormatInfo();

            setPrecision.NumberDecimalDigits = 2;

            wynik = l1 + l2;

            Console.WriteLine("Dodawanie: " + wynik.ToString("N", setPrecision));

            wynik = l1 - l2;

            Console.WriteLine("Odejmowanie: " + wynik.ToString("N", setPrecision));
            wynik = l1 * l2;

            Console.WriteLine("Mnożenie: " + wynik.ToString("N", setPrecision));

            wynik = l1 / l2;

            Console.WriteLine("Dzielenie: " + wynik.ToString("N", setPrecision));

        }

    }
}
