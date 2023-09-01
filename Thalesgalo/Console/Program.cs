using Biblioteca;
using System;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace ProgramaConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Informe o valor do numero para o teste:");
            n = int.Parse(Console.ReadLine());

            var RF = (Calculos.NumeroDeCiclos(n));

            string EntradaDeDados = @"D:\GitHubRepos\3nPlus1\Thalesgalo\Leitura.txt";
            string SaidaDeDados = @"D:\GitHubRepos\3nPlus1\Thalesgalo\Escrita.txt";

            try
            {
                //Leitura de todas as linhas;
                string[] lines = File.ReadAllLines(EntradaDeDados);

                using (StreamWriter sw = new StreamWriter(SaidaDeDados))
                {
                    foreach (var i in lines)
                    {
                        string[] parts = i.Split(' ');

                        var start = Convert.ToInt32(parts[0]);
                        var end = Convert.ToInt32(parts[1]);

                        sw.Write(start);
                        sw.Write(' ');
                        sw.Write(end);
                        sw.Write(' ');
                        sw.Write(Calculos.CalculoDeSaida(start, end));

                        sw.WriteLine();
                    }
                }
            }
            catch
            {
                Console.WriteLine("ERRO");
            }

            Console.WriteLine($"O numero de ciclos que o nº: {n} faz é {RF}");

            System.Diagnostics.Process.Start("notepad.exe", SaidaDeDados);

            Console.ReadKey();
        }
    }
}