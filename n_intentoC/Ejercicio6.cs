using System;
namespace n_intentoC
{
    public class Ejercicio6
    {
        private double salarioAnual;

        public Ejercicio6(double salarioAnual)
        {
            this.salarioAnual = salarioAnual;
        }

        public double CalcularImpuesto()
        {
            double impuesto = 0;

            // Verificar si el salario anual excede los 12000
            if (salarioAnual > 12000)
            {
                // Calcular el impuesto como el 15% del excedente sobre 12000
                double excedente = salarioAnual - 12000;
                impuesto = 0.15 * excedente;
            }

            return impuesto;
        }

    }
}

