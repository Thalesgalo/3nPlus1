using System.ComponentModel.DataAnnotations;

namespace Biblioteca
{
    public class Calculos
    {
        public static int NumeroDeCiclos(int n)
        {
            int cont = 0;

            while (n != 1 || n < 1)
            {
                if (n % 2 == 0)
                {
                    n /= 2;
                }
                else
                {
                    n = 3 * n + 1;
                }
                cont++;
            }

            return cont + 1;
        }
        public static int CalculoDeSaida(int start, int end)
        {
            var max = 0;

            for (int j = start; j <= end; j++)
            {
                var resultado = Calculos.NumeroDeCiclos(j);
                if (resultado > max)
                {
                    max = resultado;
                }
            }
            return max;
        }
    }
}