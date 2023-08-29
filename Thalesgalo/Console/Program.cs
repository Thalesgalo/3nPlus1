using Biblioteca;
using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Informe o valor do numero para o teste:");
            n = int.Parse(Console.ReadLine());

            Console.Write(Calculos.NumeroDeCiclos(n));

            Console.ReadKey();
        }
    }
}