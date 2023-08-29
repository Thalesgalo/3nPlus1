namespace Biblioteca
{
    public class Calculos
    {
        public static int NumeroDeCiclos(int n)
        {
            int cont = 0;

            do
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

            }while (n != 1);

            return cont + 1;
        }
    }
}