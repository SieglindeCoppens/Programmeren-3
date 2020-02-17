using System;

namespace Programmeren_3
{
    class Delegate
    {
        public delegate int DoeIets(int getal1, int getal2);
        static void Main(string[] args)
        {
            DoeIets berekening = Som;

            PrintAantal(berekening, 3);
        }
        public static int Som(int getal1, int getal2)
        {
            int som = getal1 + getal2;
            return som;
        }
        public static void PrintAantal(DoeIets berekening, int aantal)
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


