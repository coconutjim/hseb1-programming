using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CL1
{
    public abstract class Integrand
    {
        public double Xmin { get; set; }
        public double Xmax { get; set; }
        public abstract double function(double x);
    }
    public class Fun_2 : Integrand
    {
        public Fun_2(double xmi, double xma)
        {
            Xmin = xmi;
            Xmax = xma;
        }
        public override double function(double x)
        {
            return 4*Math.Cos(x)*Math.Cos(x);
        }
    }
    public class Fun_1 : Integrand
    {
        public Fun_1(double xmi, double xma)
        {
            Xmin = xmi;
            Xmax = xma;
        }
        public override double function(double x)
        {
            double denominator = (x * x + 1) * (x * x + 1);
            return x / denominator;
        }
    }
    public abstract class Progr
    {
        protected uint a;
        protected uint k;
        public abstract uint A { get; set; }
        public abstract uint K { get; set; }
        public abstract double ProgrSum(uint n);
        public abstract double ProgrItemN(uint n);
    }
    public abstract class Dimensions
    {
        protected double dimX, dimY;
        protected Dimensions(double x, double y)
        {
            dimX = x;
            dimY = y;
        }
        abstract public string description();
        public void change(double k)
        {
            dimX *= k;
            dimY *= k;
        }
        abstract public double Area { get; }
        abstract public string Record { get; }
    }
    public class Ellipse : Dimensions
    {
            public Ellipse(double x, double y) : base(x, y) { }
            public override double Area
            {
                get { return Math.PI * dimX * dimY / 4; }
            }
            public override string description()
            {
                return string.Format("Эллипс: dx={0:f2},\tdy={1:f2},\tArea={2:f2}", dimX, dimY, Area);
            }
        public override string Record()
            {
                get{ return string.Format("Эллипс {0:f2} {1:f2}", dimX, dimY);}
            }
    }
        public class Triangle : Dimensions
        {
            public Triangle(double x, double y) : base(x, y) { }
            public override double Area
            {
                get { return dimX * dimY / 2; }
            }
           public override string description()
            {
                return string.Format("Треугольник: dx={0:f2},\tdy={1:f2},\tArea={2:f2}", dimX, dimY, Area);
            }
            public override string Record()
            {
                get
                { 
                    return string.Format("Треугольник {0:f2} {1:f2}", dimX, dimY);
                } 
            }
        }
    }
}
