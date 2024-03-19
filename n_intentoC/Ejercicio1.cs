
//Solicita al usuario un número y eleva este número al cuadrado solo si es positivo.

using System;
namespace n_intentoC
{
    public class Ejercicio1
    {
        public double ElevarAlCuadrado(double numero)
        {
            if (numero > 0)
            {
                return Math.Pow(numero, 2);
            }
            else
            {
                Console.WriteLine("El número ingresado no es positivo, no se puede elevar al cuadrado.");
                return numero;
            }
        }
    }
}

