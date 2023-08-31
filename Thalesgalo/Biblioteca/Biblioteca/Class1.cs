using System.IO;
using System.Threading.Channels;

namespace Biblioteca
{
    public class Calculos
    {
        public static int NumeroDeCiclos(int n)
        {
            int cont = 0;

            while (n != 1) 
            {
                if (n % 2 == 0)
                {
                    n = n / 2;
                }
                else
                {
                    n = 3 * n + 1;
                }
                cont++;
            }

            return cont + 1;
        }
        public static int CalculoDeSaida(string EntradaDeDados, string SaidaDeDados)
        {
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

                        for (int j = start; j <= end; j++)
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
                    return int.MaxValue;

                }
            }
            catch
            {
                return 0;
            }
        }
    }
}