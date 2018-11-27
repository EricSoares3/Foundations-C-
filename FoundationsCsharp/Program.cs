using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {

            // Casting, e conversão implicita

            float e = 2;
            double t = e;
            Console.WriteLine(t); // conversão implicita 



            double a;
            float b;
            a = 5.1;
            b = (float)a; // casting double para float
            Console.WriteLine(b);

            double x;
            int z;
            x = 5.1;
            z = (int)x; // casting double para int
            Console.WriteLine(z);

            int c = 5;
            int d = 2;
            double resultado = (double)c / d; // casting do resultado da divisão de dois int para double
            Console.WriteLine(resultado);
        }
    }
}