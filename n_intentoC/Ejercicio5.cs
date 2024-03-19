using System;
namespace n_intentoC
{
    public class Ejercicio5
    {
        private int numeroDia;

        public Ejercicio5(int numeroDia)
        {
            this.numeroDia = numeroDia;
        }

        public string ObtenerNombreDia()
        {
            switch (numeroDia)
            {
                case 1:
                    return "Lunes";
                case 2:
                    return "Martes";
                case 3:
                    return "Miércoles";
                case 4:
                    return "Jueves";
                case 5:
                    return "Viernes";
                case 6:
                    return "Sábado";
                case 7:
                    return "Domingo";
                default:
                    return "Desconocido";
            }
        }

        public bool EsLaborable()
        {
            return numeroDia >= 1 && numeroDia <= 5;
        }

        public void VerificarDiaLaborable()
        {
            string nombreDia = ObtenerNombreDia();
            bool laborable = EsLaborable();

            if (laborable)
            {
                Console.WriteLine($"El día {numeroDia} ({nombreDia}) es laborable.");
            }
            else
            {
                Console.WriteLine($"El día {numeroDia} ({nombreDia}) no es laborable.");
            }
        }
    }
}

