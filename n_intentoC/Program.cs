using itm_2;
using n_intentoC;
using static System.Runtime.InteropServices.JavaScript.JSType;
class Program
{
    static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("Seleccione el ejercicio que desea ejecutar:");
            Console.WriteLine("1. Ejercicio Uno");
            Console.WriteLine("2. Ejercicio Dos");
            Console.WriteLine("3. Ejercicio Tres");
            Console.WriteLine("4. Ejercicio Cuatro");
            Console.WriteLine("5. Ejercicio Cinco");
            Console.WriteLine("6. Ejercicio Seis");
            Console.WriteLine("7. Ejercicio Siete");
            Console.WriteLine("8. Ejercicio Ocho");
            Console.WriteLine("9. Ejercicio Nueve");
            Console.WriteLine("10. Ejercicio Diez");
            Console.WriteLine("11. Ejercicio Once");
            Console.WriteLine("12. Ejercicio Doce");
            Console.WriteLine("13. Ejercicio Trece");
            Console.WriteLine("0. Salir");

            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 0:
                    continuar = false;
                    Console.WriteLine("Saliendo del programa...");
                    break;
                case 1:
                    EjercicioUno();
                    break;
                case 2:
                    EjercicioDos();
                    break;
                case 3:
                    EjercicioTres();
                    break;
                case 4:
                    EjercicioCuatro();
                    break;
                case 5:
                    EjercicioCinco();
                    break;
                case 6:
                    EjercicioSeis();
                    break;
                case 7:
                    EjercicioSiete();
                    break;
                case 8:
                    EjercicioOcho();
                    break;
                case 9:
                    EjercicioNueve();
                    break;
                case 10:
                    EjercicioDiez();
                    break;
                case 11:
                    EjercicioOnce();
                    break;
                case 12:
                    EjercicioDoce();
                    break;
                case 13:
                    EjercicioTrece();
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione un número del menú.");
                    break;
            }
        }
    }

    static void EjercicioUno()
    {
        Console.WriteLine("EJERCICIO UNO");
        Console.WriteLine("Ingrese un número:");
        double numero = Convert.ToDouble(Console.ReadLine());

        Ejercicio1 ejercicio = new Ejercicio1();
        double resultado = ejercicio.ElevarAlCuadrado(numero);

        Console.WriteLine($"El resultado de elevar al cuadrado el número es: {resultado}");
    }

    static void EjercicioDos()
    {
        Console.WriteLine("EJERCICIO DOS");

        Console.WriteLine("Ingrese el primer número:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo número:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Ejercicio2 ejercicio2 = new Ejercicio2();
        int result = ejercicio2.squareOrtriple(num1, num2);
        Console.WriteLine($"El resultado es: {result}");
    }

    static void EjercicioTres()
    {
        Console.WriteLine("EJERCICIO TRES");
        Console.WriteLine("Ingrese un número:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Ejercicio3 ejercicio3 = new Ejercicio3();
        double num = ejercicio3.squareOrRoot(num1);
        Console.WriteLine($"El resultado es: {num}");
    }

    static void EjercicioCuatro()
    {
        Console.WriteLine("EJERCICIO CUATRO");
        Console.WriteLine("Ingrese el radio de la circunferencia:");
        double radio = Convert.ToDouble(Console.ReadLine());
        Ejercicio4 ejercicio4 = new Ejercicio4();
        double result_perimeter = ejercicio4.circlePerimeter(radio);
        Console.WriteLine($"El perimetro es : {result_perimeter} ");
    }

    static void EjercicioCinco()
    {
        Console.WriteLine("EJERCICIO CINCO");
        Console.WriteLine("Ingrese un número entre 1 y 7:");
        int numeroDia = Convert.ToInt32(Console.ReadLine());
        Ejercicio5 dia = new Ejercicio5(numeroDia);
        dia.VerificarDiaLaborable();
    }

    static void EjercicioSeis()
    {
        Console.WriteLine("EJERCICIO SEIS");
        Console.WriteLine("Ingrese su salario anual:");
        double salario = Convert.ToDouble(Console.ReadLine());
        Ejercicio6 impuestoSalario = new Ejercicio6(salario);
        double impuesto = impuestoSalario.CalcularImpuesto();
        if (impuesto > 0)
        {
            Console.WriteLine($"Su salario anual excede los 12000. El impuesto a pagar es: {impuesto:C}");
        }
        else
        {
            Console.WriteLine("Su salario anual no excede los 12000. No tiene impuesto que pagar.");
        }
    }

    static void EjercicioSiete()
    {
        Console.WriteLine("EJERCICIO SIETE");
        Console.WriteLine("Ingrese el primer número:");
        double numero1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo número:");
        double numero2 = Convert.ToDouble(Console.ReadLine());
        Ejercicio7 ejercicios = new Ejercicio7(numero1, numero2);
        double residuo = ejercicios.CalcularResiduo();
        Console.WriteLine($"El residuo de la división es: {residuo}");
    }

    static void EjercicioOcho()
    {
        Console.WriteLine("EJERCICIO OCHO");
        Ejercicio8 ejercicio8 = new Ejercicio8();
        int results = ejercicio8.sumar_pares(1, 50);
        Console.WriteLine($"El resultado de la suma es: {results}");
    }

    static void EjercicioNueve()
    {
        Console.WriteLine("EJERCICIO NUEVE");
        Console.WriteLine("Introduzca el numerador de la primera fracción:");
        int numFracc1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Introduzca el denominador de la primera fracción:");
        int den1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Introduzca el numerador de la segunda fracción:");
        int numFracc2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Introduzca el denominador de la segunda fracción:");
        int den2 = int.Parse(Console.ReadLine());
        Ejercicio9 f1 = new Ejercicio9(numFracc1, den1);
        Ejercicio9 f2 = new Ejercicio9(numFracc2, den2);
        Ejercicio9 diferencia = f1 - f2;
        Console.WriteLine($"La diferencia entre {f1} y {f2} es: {diferencia}");
    }

    static void EjercicioDiez()
    {
        Console.WriteLine("EJERCICIO DIEZ");
        Console.WriteLine("Introduzca una palabra:");
        string palabra = Console.ReadLine();
        Ejercicio10 cadena = new Ejercicio10(palabra);
        int longitud = cadena.Longitud();
        Console.WriteLine($"La longitud de la palabra '{cadena}' es: {longitud}");
    }

    static void EjercicioOnce()
    {
        Console.WriteLine("EJERCICIO ONCE");
        Console.WriteLine("Introduzca el primer número:");
        double num11 = double.Parse(Console.ReadLine());
        Console.WriteLine("Introduzca el segundo número:");
        double num12 = double.Parse(Console.ReadLine());
        Console.WriteLine("Introduzca el tercer número:");
        double num13 = double.Parse(Console.ReadLine());
        Console.WriteLine("Introduzca el cuarto número:");
        double num14 = double.Parse(Console.ReadLine());
        double promedio = Ejercicio11.Promedio(num11, num12, num13, num14);
        Console.WriteLine($"El promedio de los números {num11}, {num12}, {num13} y {num14} es: {promedio}");
    }

    static void EjercicioDoce()
    {
        Console.WriteLine("EJERCICIO DOCE");
        Console.WriteLine("Introduzca el primer número:");
        double numeros = double.Parse(Console.ReadLine());
        Console.WriteLine("Introduzca el segundo número:");
        double numeros1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Introduzca el tercer número:");
        double num3 = double.Parse(Console.ReadLine());
        Console.WriteLine("Introduzca el cuarto número:");
        double num4 = double.Parse(Console.ReadLine());
        Console.WriteLine("Introduzca el quinto número:");
        double num5 = double.Parse(Console.ReadLine());
        Ejercicio12 n1 = new Ejercicio12(numeros);
        Ejercicio12 n2 = new Ejercicio12(numeros1);
        Ejercicio12 n3 = new Ejercicio12(num3);
        Ejercicio12 n4 = new Ejercicio12(num4);
        Ejercicio12 n5 = new Ejercicio12(num5);
        Ejercicio12 menor = Ejercicio12.Menor(Ejercicio12.Menor(n1, n2), Ejercicio12.Menor(n3, n4));
        menor = Ejercicio12.Menor(menor, n5);
        Console.WriteLine($"El número más pequeño es: {menor}");
    }

    static void EjercicioTrece()
    {
        Console.WriteLine("EJERCICIO TRECE");
        Console.WriteLine("Introduzca una palabra:");
        string palabras = Console.ReadLine();
        Ejercicio13 p = new Ejercicio13(palabras);
        int numeroVocales = p.ContarVocales();
        Console.WriteLine($"La palabra '{p}' tiene {numeroVocales} vocales.");
    }
}