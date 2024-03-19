using System;
namespace n_intentoC
{
    public class Ejercicio9
    {
        private int numerador;
        private int denominador;

        public Ejercicio9(int numerador, int denominador)
        {
            this.numerador = numerador;
            this.denominador = denominador;
        }

        public int Numerador { get => numerador; }
        public int Denominador { get => denominador; }

        public static Ejercicio9 operator -(Ejercicio9 f1, Ejercicio9 f2)
        {
            int mcd = Math.Abs(MCD(f1.denominador, f2.denominador));
            int numeradorDiferencia = (f1.numerador * mcd) - (f2.numerador * mcd);
            int denominadorDiferencia = mcd * f1.denominador;
            return new Ejercicio9(numeradorDiferencia, denominadorDiferencia);
        }

        public override string ToString()
        {
            return $"{numerador}/{denominador}";
        }

        private static int MCD(int a, int b)
        {
            while (b != 0)
            {
                int aux = b;
                b = a % b;
                a = aux;
            }
            return a;
        }

    }
}

