using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCastingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 20;

            long b = a;

            Console.WriteLine(b);

            long l = 34;
            int c =(int)l;

            Console.WriteLine(c);

            float f = 23.4F;
            double d = f;
            Console.WriteLine(d);

            Console.WriteLine(f);
            double g = 78.9;
            float h = (float)g;
            Console.WriteLine(h);
            Console.ReadLine();


        }
    }
}
