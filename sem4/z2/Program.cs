using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CL1;
using System.IO;
using System.Collections.Generic;

namespace z2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ellipse e = new Ellipse(3, 8);
            Triangle t = new Triangle(5, 4);
            Dimensions[] fig = new Dimensions[4];
            fig[0] = e;
            fig[1] = t;
            fig[2] = new Ellipse(4, 6);
            fig[3] = new Ellipse(2, 8);
            StreamWriter outFile = null;
            if (outFile==null)
            {
            }
            outFile.Flush();
            outFile.Close();
            StreamReader inputFile = new StreamReader("Фигуры");
            List<string> input=new List<string>;
            while (true)
            {
                string line=inputFile.ReadLine();
                if (line==null) break;
                input.Add(line);
            }
            Dimensions[] result=new Dimensions[input.Count];
            int count=0;
            Console.WriteLine("Записи, прочитанные из файла");
            foreach (string s in input)
            {
                Console.WriteLine(s);
                string[] arr=s.Split(' ');
                double x=double.Parse(arr[1]);
                double y=double.Parse(arr[2]);
                //if arr[0]="Эллипс"
                Console.WriteLine("Сведения о восстановленных и измененных объектах: ");
                foreach (Dimensions d in result)
                {
                    d.change(10);
                    Console.WriteLine(d.description());
                }
            }
        }
    }
}
