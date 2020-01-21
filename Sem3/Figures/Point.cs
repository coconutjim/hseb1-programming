using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figures
{
    public class Point
    {
        double x, y;
        public double X { get { return x; } set { x = value; } }
        public double Y { get { return y; } set { y = value; } }
        virtual public void display()
        {
            Console.WriteLine("Point: X={0},Y={1};", X, Y);
        }
        virtual public double Area
        { get { return 0; } }
    }
    public class Circle : Point
    {
        double rad;
        public Circle(int xi, int yi, double r)
            : base()
        {
            X = xi;
            Y = yi;
            rad = r;
        }
        public double Rad { get { return rad; } set { rad = value; } }
        public double Len { get { return 2 * rad * Math.PI; } }
        public override double Area
        {
            get
            {
                return rad * rad * Math.PI;
            }
        }
        override public void display() // Вывести характеристики
        {
            Console.WriteLine("Centre Circle: X={0}, Y={1}; " + "Radius={2:f2}, Length={3,6:f2}", X, Y, rad, Len);
        }
    }
    public class Square : Point 
    {
        double side; 
        public Square(int xi, int yi, double s) 
            : base() { X = xi; Y = yi; side = s; }
        public double Side { get { return side; } set { side = value; } }
        public double Len { get { return 4 * side; } }
        override public double Area { get { return side * side; } }
        override public void display() 
        {
            Console.WriteLine("Centre Square: X={0}, Y={1}; " + "Side={2:f2}, Perimeter={3,6:f2}", X, Y, side, Len);
        }
    }
}
