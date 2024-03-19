using System;
namespace itm_2
{
    public class Ejercicio8
    {
        public int sumar_pares(int inicio, int fin)
        {
            int suma = 0;
            for (int i = inicio; i <= fin; i++)
            {
                if (esPar(i))
                {
                    suma += i;
                }
            }

            return suma;
        }

        private bool esPar(int numero)
        {
            return numero % 2 == 0;
        }

    }
}



