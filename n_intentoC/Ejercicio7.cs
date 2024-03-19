using System;
namespace itm_2
{

    class Ejercicio7
    {
        private double numero1;
        private double numero2;

        public Ejercicio7(double numero1, double numero2)
        {
            this.numero1 = numero1;
            this.numero2 = numero2;
        }

        public double CalcularResiduo()
        {
            // Calcular el residuo de la división del primer número entre el segundo número
            return numero1 % numero2;
        }
    }
}
