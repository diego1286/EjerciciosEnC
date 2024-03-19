using System;
namespace n_intentoC
{
    public class Ejercicio10
    {
        private string texto;

        public Ejercicio10(string texto)
        {
            this.texto = texto;
        }

        public int Longitud()
        {
            return texto.Length;
        }

        public override string ToString()
        {
            return texto;
        }

    }
}

