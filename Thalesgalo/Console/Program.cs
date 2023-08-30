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
            int n
               ;

            Console.Write("Informe o valor do numero para o teste:");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine(Calculos.NumeroDeCiclos(n));

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

                        var max = 0;

                        for (int j = start;  j <= end; j++)
                        {
                            var resultado = Calculos.NumeroDeCiclos(j);
                            if (resultado > max)
                            {
                                max = resultado;
                            }
                        }

                        sw.Write(start);
                        sw.Write(' ');
                        sw.Write(end);
                        sw.Write(' ');
                        sw.Write(max);

                        sw.WriteLine();
                    }

                    System.Diagnostics.Process.Start("notepad.exe", SaidaDeDados);
                }
            }
            catch
            {
                Console.WriteLine("ERRO");
            }

            Console.ReadKey();
        }
    }
}