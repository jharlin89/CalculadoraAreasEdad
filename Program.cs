
using System;

class Program
{
    // Funcion para calcular el area de un triangulo
    static double CalcularTriangulo(double baseTriangulo, double altura)
    {
        return (baseTriangulo * altura) / 2;
    }

    // Funcion para calcular el area de un cuadrado
    static double CalcularCuadrado(double lado)
    {
        return lado * lado;
    }

    // Funcion para calcular el area de un circulo
    static double CalcularCirculo(double radio)
    {
        return Math.PI * radio * radio;
    }

    // Funcion para verificar la mayoria de edad
    static string VerificarEdad(int edad)
    {
        if (edad >= 18)
        {
            return "La persona es mayor de edad.";
        }
        else
        {
            return "La persona es menor de edad.";
        }
    }

    static void Main()
    {
        int opcion;

        do
        {
            Console.Clear();

            Console.WriteLine("================================");
            Console.WriteLine("     CALCULADORA Y CONSULTA");
            Console.WriteLine("================================");
            Console.WriteLine("1. Calcular area de un triangulo");
            Console.WriteLine("2. Calcular area de un cuadrado");
            Console.WriteLine("3. Calcular area de un circulo");
            Console.WriteLine("4. Consultar mayoria de edad");
            Console.WriteLine("5. Salir");
            Console.WriteLine("================================");
            Console.Write("Seleccione una opcion: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Opcion no valida.");
                Console.ReadKey();
                opcion = 0;
                continue;
            }

            double resultado;
            double valor1;
            double valor2;
            int edad;

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese la base del triangulo: ");
                    valor1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Ingrese la altura: ");
                    valor2 = Convert.ToDouble(Console.ReadLine());

                    if (valor1 > 0 && valor2 > 0)
                    {
                        resultado = CalcularTriangulo(valor1, valor2);
                        Console.WriteLine("El area del triangulo es: " + resultado);
                    }
                    else
                    {
                        Console.WriteLine("Los valores deben ser mayores que cero.");
                    }
                    break;

                case 2:
                    Console.Write("Ingrese el lado del cuadrado: ");
                    valor1 = Convert.ToDouble(Console.ReadLine());

                    if (valor1 > 0)
                    {
                        resultado = CalcularCuadrado(valor1);
                        Console.WriteLine("El area del cuadrado es: " + resultado);
                    }
                    else
                    {
                        Console.WriteLine("El lado debe ser mayor que cero.");
                    }
                    break;

                case 3:
                    Console.Write("Ingrese el radio del circulo: ");
                    valor1 = Convert.ToDouble(Console.ReadLine());

                    if (valor1 > 0)
                    {
                        resultado = CalcularCirculo(valor1);
                        Console.WriteLine("El area del circulo es: " + resultado);
                    }
                    else
                    {
                        Console.WriteLine("El radio debe ser mayor que cero.");
                    }
                    break;

                case 4:
                    Console.Write("Ingrese su edad: ");
                    edad = Convert.ToInt32(Console.ReadLine());

                    if (edad >= 0)
                    {
                        Console.WriteLine(VerificarEdad(edad));
                    }
                    else
                    {
                        Console.WriteLine("La edad no puede ser negativa.");
                    }
                    break;

                case 5:
                    Console.WriteLine("Gracias por utilizar el programa.");
                    break;

                default:
                    Console.WriteLine("Seleccione una opcion del 1 al 5.");
                    break;
            }

            if (opcion != 5)
            {
                Console.WriteLine();
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcion != 5);
    }
}
