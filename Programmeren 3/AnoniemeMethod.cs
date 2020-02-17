using System;
using System.Collections.Generic;
using System.Text;

namespace Programmeren_3
{
    class AnoniemeMethode
    {
        static void Main(string[] args)
        {
            Func<double, double, double> getDeling = delegate (double x, double y)
            {
                return x / y;
            };
            double deling = getDeling(3.5,1.5);
            Console.WriteLine(deling);
        }
    }
}
