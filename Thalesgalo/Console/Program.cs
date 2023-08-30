using Biblioteca;
using System;
using System.IO;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int n;

            /*Console.Write("Informe o valor do numero para o teste:");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine(Calculos.NumeroDeCiclos(n));*/

            string EntradaDeDados = @"D:\Users\CostaTh\Leitura.txt";
            string SaidaDeDados = @"D:\Users\CostaTh\Escrita.txt";

            //Leitura de todas as linhas;
            try
            {
                string[] lines = File.ReadAllLines(EntradaDeDados);

                using (StreamWriter sw = new StreamWriter(SaidaDeDados))
                {
                    foreach (var i in lines)
                    {
                        string[] parts = i.Split(' ');

                        foreach (string i in parts)
                        {
                            sw.WriteLine(i) ;
                        
                        }
                    }

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