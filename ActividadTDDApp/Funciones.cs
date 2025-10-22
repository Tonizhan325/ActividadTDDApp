using System.ComponentModel;

namespace ActividadTDDApp
{
    public class Funciones
    {
        public static long CalcularFactorial(int n)
        {
            if (n < 0)
                return -1;
            if (n == 0)
                return 1;
            long result = 1;
            for(int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
