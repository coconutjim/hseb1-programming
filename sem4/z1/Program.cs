using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CL1;

namespace z1
{
    class Program
    {
        public static double rectangle(Integrand f, int n)
        {
            double h = (f.Xmax - f.Xmin) / n;
            double sum = 0;
            for (int i = 0; i < n; i++)
                sum += f.function(f.Xmin + h / 2 + i * h);
            return sum * h;
        }
        static void Main()
        {
            Fun_1 f1 = new Fun_1(-1, 2);
            Console.WriteLine("Интеграл_1 = {0:g6}", rectangle(f1, 20));
            Console.WriteLine("Интеграл_1 = {0:g7}", rectangle(new Fun_2(0, 0.5), 20));
            Console.ReadKey();
        }
    }
}
