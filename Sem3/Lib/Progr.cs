using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib
{
    public class Progr
    {
        protected uint a;
        protected uint k;
        public Progr()
        {
            a = 0;
            k = 0;
            Console.WriteLine("::Progr");
        }
        public Progr(uint aVal, uint kVal)
        {
            a = aVal;
            k = kVal;
            Console.WriteLine("::Progr(uint,uint)");
        }
        public uint A
        {
            get {Console.WriteLine("Progr::A");return a;}
            set {a=value;}
        }
        public uint K
        {
            get {return k;}
            set {k=value;}
        }
    }
    public class GeomProgr : Progr
    {
        public GeomProgr()
        {
            a = 1;
            k = 1;
            Console.WriteLine("::GeomProgr");
        }
        public GeomProgr(uint b, uint q)
        {
            if (b == 0 || q == 0)
                throw new Exception("Ошибка в аргументах конструктора!");
            a = b;
            k = q;
            Console.WriteLine("::GeomProgr(uint,uint)");
        }
        public uint A
        {
            get { Console.WriteLine("GeomProgr::A"); return a; }
            set
            {
                if (value == 0)
                    throw new Exception("Недопустимое значение первого члена прогрессии!");
                a = value;
            }
        }
        public uint K
        {
            get { return a; }
            set
            {
                if (value == 0)
                    throw new Exception("Недопустимое значение знаменателя прогрессии!");
                k = value;
            }
        }
        public double ProgrItem(uint n)
        {
            return A * Math.Pow(K, n - 1);
        }
        public double ProgrSum(uint n)
        {
            if (A != 1)
                return A * Math.Pow(K, n) - 1 / (K - 1);
            else
                return 1;
        }
    }
}
