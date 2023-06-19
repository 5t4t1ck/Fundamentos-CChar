// Parte 4
//Módulo de dos números enteros:
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Cálculo del módulo de dos números enteros");
        Console.Write("Ingrese el dividendo: ");
        int dividendo;
        bool isValidDividendo = int.TryParse(Console.ReadLine(), out dividendo);
        Console.Write("Ingrese el divisor: ");
        int divisor;
        bool isValidDivisor = int.TryParse(Console.ReadLine(), out divisor);
        if (isValidDividendo && isValidDivisor && divisor != 0)
        {
            int modulo = dividendo % divisor;
            Console.WriteLine("El módulo de la división es: " + modulo);
        }
        else
        {
            Console.WriteLine("Los valores ingresados no son números enteros válidos o el divisor es cero.");
        }
        Console.WriteLine("Presione cualquier tecla para salir.");
        Console.ReadKey();
    }
}

