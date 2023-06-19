// Parte 4
//Suma de dos números enteros:
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el primer número entero: ");
        string input1 = Console.ReadLine();
        bool isValidInput1 = int.TryParse(input1, out int num1);

        Console.Write("Ingrese el segundo número entero: ");
        string input2 = Console.ReadLine();
        bool isValidInput2 = int.TryParse(input2, out int num2);

        if (!isValidInput1 || !isValidInput2)
        {
            Console.WriteLine("El valor ingresado no es válido. Asegúrese de ingresar números enteros.");
        }
        else
        {
            int suma = num1 + num2;
            Console.WriteLine("La suma de los dos números es: " + suma);
        }
        Console.WriteLine("Presione cualquier tecla para salir.");
        Console.ReadKey();
    }
}
