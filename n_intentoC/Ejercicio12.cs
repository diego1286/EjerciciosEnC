using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace n_intentoC
{
    public class Ejercicio12
    {
        private double valor;

        public Ejercicio12(double valor)
        {
            this.valor = valor;
        }
        public double Valor { get => valor; }

        public static Ejercicio12 Menor(Ejercicio12 num1, Ejercicio12 num2)
        {
            return num1.valor < num2.valor ? num1 : num2;
        }

        public override string ToString()
        {
            return valor.ToString();
        }


    }
}

