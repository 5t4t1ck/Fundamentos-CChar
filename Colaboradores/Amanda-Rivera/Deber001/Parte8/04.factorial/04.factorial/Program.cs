// Parte8
//Calcular el factorial de un número:

using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        int factorial = 1;

        for (int i = 1; i <= numero; i++)
        {
            factorial *= i;
        }

        Console.WriteLine("El factorial de " + numero + " es: " + factorial);
    }
}

