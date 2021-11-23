using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idzi_Jan_2P2___ZadniaWstępne
{
    class Zadanie9
    {
        public void solution()
        {
            Console.WriteLine();
            Console.WriteLine("----------------Zadanie 9--------------");

            DateTime data = DateTime.Today;
            int day = data.DayOfYear;
            int ile_dni = 366 - day;


            Console.WriteLine("Do końca roku zostało : " + ile_dni + " dni!");
        }

    }
}
