// Parte 4
//Resta de dos números de punto flotante:
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Resta de dos números de punto flotante");

        Console.Write("Ingrese el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double resta = num1 - num2;

        Console.WriteLine("La resta de los dos números es: " + resta);
        Console.WriteLine("Presione cualquier tecla para salir.");
        Console.ReadKey();
    }
}

