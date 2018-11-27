using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Saída de dados em C# utiliza-se do método Console.ReadLine

            int n1 = int.Parse(Console.ReadLine()); // O método Parse, converte o tipo de dado do ReadLine que por padrão é String, para int

            char ch = char.Parse(Console.ReadLine());

            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vet = Console.ReadLine().Split(' ');

            string nome = vet[0];

            char sexo = char.Parse(vet[1]);

            int idade = int.Parse(vet[2]);

            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou:");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}