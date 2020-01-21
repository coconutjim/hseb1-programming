using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Figures;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point();
            p.display();
            Console.WriteLine("p.Area дляPoint = " + p.Area);
            p = new Circle(1, 2, 6);
            p.display();
            Console.WriteLine("p.Area дляCircle = " + p.Area);
            p = new Square(3, 5, 8);
            p.display();
            Console.WriteLine("p.Area дляSquare = " + p.Area);
        }
    }
}
