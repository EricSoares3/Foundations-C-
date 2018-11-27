using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Saída de dados em C# utiliza-se do método Console.ReadLine

            string frase = Console.ReadLine();

            string x = Console.ReadLine();

            string y = Console.ReadLine();

            string z = Console.ReadLine();

            string[] v = Console.ReadLine().Split(' '); // Irá criar um vetor, que irá armazenar 3 variaveis, que depois irá ser divido pelo método Split

            string a = v[0]; // atribuição do valor de acordo com a posição do indice

            string b = v[1];   // atribuição do valor de acordo com a posição do indice 

            string c = v[2];    // atribuição do valor de acordo com a posição do indice

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}