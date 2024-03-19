// Solicita al usuario dos números. Si el primero es mayor, devuelva su doble, de lo contrario devuelva el triple del segundo.

using System;
namespace n_intentoC
{
    public class Ejercicio2
    {
        public int squareOrtriple(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1 * 2;
            }
            else
            {
                return num2 * 3;
            }
        }

    }
}

