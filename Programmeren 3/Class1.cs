using System;

namespace Programmeren_3
{
    class Func
    {
        static void Main(string[] args)
        {
           Func<int, int, int> berekening = Som;

            PrintAantal(berekening, 3);
        }
        public static int Som(int getal1, int getal2)
        {
            int som = getal1 + getal2;
            return som;
        }
        public static void PrintAantal(Func<int, int, int> berekening, int aantal)
        {
            int x = berekening(3, 4);
            int teller = 0;
            while (teller < aantal)
            {
                Console.WriteLine(x);
                teller++;
            }

        }
    }
}
