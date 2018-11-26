using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 32;
            double saldo = 10.35784;
            String nome = "Maria";

            // Há três maneiras de imprimir varias variaveis na tela de uma vez, utizando apenas um Console.WriteLine
            // São elas: Utilizando-se dos Placeholders, Interpolações e a mais antiga Concatenação
            // O que fica exemplificado a seguir:

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo); // Placeholder 

            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais"); // Interpolação

            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a "
            + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais"); // Concatenação
        }
    }
}