// Parte 4
//División de dos números de punto flotante:
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("División de dos números de punto flotante");
        Console.Write("Ingrese el dividendo: ");
        double dividendo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el divisor: ");
        double divisor = Convert.ToDouble(Console.ReadLine());

        if (divisor != 0)
        {
            double division = dividendo / divisor;
            Console.WriteLine("El resultado de la división es: " + division);
        }
        else
        {
            Console.WriteLine("No es posible dividir entre cero.");
        }
        Console.WriteLine("Presione cualquier tecla para salir.");
        Console.ReadKey();
    }
}
