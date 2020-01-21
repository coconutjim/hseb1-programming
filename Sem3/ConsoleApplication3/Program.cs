using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Figures;

namespace ConsoleApplication3
{
    class Program
    {
        static Point[] figArray(int n)
        { 
            Point[] temp = new Point[n];
            Random gen = new Random();
            for (int i = 0; i < n; i++)
                if (gen.Next(0, 2) == 0)
                    temp[i] = new Circle(gen.Next(1, 10), gen.Next(1, 9), 10 * gen.NextDouble());
                else
                    temp[i] = new Square(gen.Next(1, 10), gen.Next(1, 9), 10 * gen.NextDouble());
            return temp;
        }
        static void Main(string[] args)
        {
            Point[] arFif = figArray(5);
            int numC = 0, numS = 0;
            Console.WriteLine("Исходный массив:");
            foreach (Point p in arFif)
            {
                Console.Write("Area={0:f2}\t", p.Area);
                p.display();
                if (p is Circle) numC++;
                if (p is Square) numS++;
            }
            Console.WriteLine("Число объектовCircle: " + numC);
            Console.WriteLine("Число объектовSquare: " + numS);
            Array.Sort(arFif, compArea);
            Console.WriteLine("Массив упорядочен по площадям фигур:");
            foreach (Point p in arFif)
            {
                Console.Write("Area={0:f2}\t", p.Area);
                p.display();
            }
            Array.Sort(arFif, compPerimeter);
            Console.WriteLine("Массив упорядочен по убыванию периметров фигур:");
            foreach (Point p in arFif)
            {
                p.display();
            }
        }
        static int compArea(Point x, Point y)
        { 
            if (x.Area > y.Area) return 1;
            if (x.Area == y.Area) return 0;
            return -1;
        } 
        static int compPerimeter(Point x, Point y)
        { 
            double lx = (x is Circle) ? ((Circle)x).Len : ((Square)x).Len;
            double ly = (y is Circle) ? ((Circle)y).Len : ((Square)y).Len;
            if (lx < ly) return 1;
            if (lx == ly) return 0;
            return -1;
        } 
    }
}
