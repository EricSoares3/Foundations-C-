using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {

            // Casting é converter o tipo da varivel em outro, como pode ser observados nos exemplos a seguir: 

            // Exemplo 1
            int a = 5;
            int b = 2;
            double resultado = (double)a / b;
            Console.WriteLine(resultado);

            // Exemplo 2
            double c;
            int d;
            c = 5.1;
            d = (int)c;
            Console.WriteLine(d);
        }
    }
}