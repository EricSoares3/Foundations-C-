using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {

            int n1 = 3 + 4 * 2; // sem parênteses o grau de importância será divisão e multiplicação primeiro

            int n2 = (3 + 4) * 2; // parênteses tem grau de importância maior, assim començando por quem está dentro dela

            int n3 = 17 % 3; // operador mod, resposta é o resto da divisão

            double n4 = 10.0 / 8.0; // se fosse int, iria retornar apenas 1, devido a não ser um ponto flutuante

            double a = 1.0, b = -3.0, c = -4.0;

            double delta = Math.Pow(b, 2.0) - 4.0 * a * c; // Math pow é uma função matematica ja pronto, para calcular potência

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a); // Math sqrt é uma função matematica para calcular raiz quadrada

            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a); // Math sqrt é uma função matematica para calcular raiz quadrada

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
        }
    }
}