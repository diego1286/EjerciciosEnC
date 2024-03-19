using System;
namespace n_intentoC
{
    public class Ejercicio3
    {
        public double squareOrRoot(double num1)
        {
            if (num1 > 0)
            {
                double square_root = Math.Sqrt(num1);
                return square_root;
            }
            else
            {
                return num1 * 2;
            }
        }

    }
}

