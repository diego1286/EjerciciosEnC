using System;
namespace n_intentoC
{
    public class Ejercicio13
    {
        private string texto;

        public Ejercicio13(string texto)
        {
            this.texto = texto;
        }

        public int ContarVocales()
        {
            int vocales = 0;
            foreach (char letra in texto.ToLower())
            {
                if ("aeiou".Contains(letra))
                {
                    vocales++;
                }
            }
            return vocales;
        }

        public override string ToString()
        {
            return texto;
        }

    }
}

