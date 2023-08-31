using Biblioteca;
using System;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Informe o valor do numero para o teste:");
            n = int.Parse(Console.ReadLine());

            var RF = (Calculos.NumeroDeCiclos(n));

            Console.WriteLine($"O numero de ciclos que o nº: {n} faz é {RF}");

            string EntradaDeDados = @"D:\GitHubRepos\3nPlus1\Thalesgalo\Leitura.txt";
            string SaidaDeDados = @"D:\GitHubRepos\3nPlus1\Thalesgalo\Escrita.txt";

            var j = (Calculos.CalculoDeSaida(EntradaDeDados, SaidaDeDados));

            // System.Diagnostics.Process.Start("notepad.exe", SaidaDeDados);

            Console.ReadKey();
        }
    }
}