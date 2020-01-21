using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Создание объектов");
            GeomProgr emptyObj = new GeomProgr();
            GeomProgr geomObj = new GeomProgr(2,2);
            Console.WriteLine("Вывод по ссылке типа GeomProgr");
            Console.WriteLine(geomObj.A+" ");
            Console.WriteLine();
            Console.WriteLine("Вывод по ссылке типа Progr");
            Progr progrObj = geomObj;
            Console.WriteLine(progrObj.A + " ");
            Console.ReadKey();
        }
    }
}
