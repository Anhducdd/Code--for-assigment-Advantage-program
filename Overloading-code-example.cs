using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloadingexamplecode
{
    class Program
    {
        static int calculatenumber(int x, int y)
        {
            return x + y;
        }

        static double calculatenumber(double x, double y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            int cal1 = calculatenumber(1, 5);
            double cal2 = calculatenumber(2.1, 1.75);
            Console.WriteLine("Int Calculator: " + cal1);
            Console.WriteLine("Double Calculator: " + cal2);
            Console.ReadLine();
        }
    }
}
