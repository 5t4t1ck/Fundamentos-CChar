// Parte 4
//Multiplicación de dos números enteros:
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el primer número entero: ");
        int num1;
        bool isValidNum1 = int.TryParse(Console.ReadLine(), out num1);

        Console.Write("Ingrese el segundo número entero: ");
        int num2;
        bool isValidNum2 = int.TryParse(Console.ReadLine(), out num2);

        if (isValidNum1 && isValidNum2)
        {
            int multiplicacion = num1 * num2;
            Console.WriteLine("El resultado de la multiplicación es: " + multiplicacion);
        }
        else
        {
            Console.WriteLine("Los valores ingresados no son números enteros válidos.");
        }
        Console.WriteLine("Presione cualquier tecla para salir.");
        Console.ReadKey();
    }
}

