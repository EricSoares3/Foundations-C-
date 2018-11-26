using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            String nome = "Maria";

            // A diferença entre Console.write e Console.writeLine é que o sem Line ele não faz uma quebra de linha.


            Console.Write("Bom dia!"); 
            Console.WriteLine("Boa tarde!");
            Console.WriteLine("Boa noite!");
            Console.WriteLine("---------------------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2")); // O método toString("F2") é usado para delimitar quantos números irão vir após a virgula
            Console.WriteLine(saldo.ToString("F4")); // O método toString("F2") é usado para delimitar quantos números irão vir após a virgula
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture)); // O outro parâmetro passado para o método toString, no caso
            // CultureInfo.InvariantCulture, faz com que ele ignore todos os tipos de delimitação de cada país ( seja virgula, etc ) para apenas ponto ( . ) 
        }
    }
}