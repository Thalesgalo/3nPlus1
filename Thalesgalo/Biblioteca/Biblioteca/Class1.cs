namespace Biblioteca
{
    public class Calculos
    {
        public int calulos(int n)
        {
            int cont = 0;

            if (n == 1)
            {
                return 0;
            }

            while (n == 1)
            {
                if (n % 2 == 0)
                {
                    cont = 3 * n + 1;
                }
                else if (n % 2 - 1 == 0)
                {
                    cont = n/2;
                }
                
            }

            return cont;


        }




    }
}