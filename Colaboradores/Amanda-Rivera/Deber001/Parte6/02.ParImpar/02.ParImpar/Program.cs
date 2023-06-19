// Parte 6
//Verificar si un número es par o impar:
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Verificación de número par o impar");
        Console.Write("Ingrese un número entero: ");
        int numero;
        bool isValidNumero = int.TryParse(Console.ReadLine(), out numero);

        if (isValidNumero)
        {
            if (numero % 2 == 0)
            {
                Console.WriteLine("El número ingresado es par.");
            }
            else
            {
                Console.WriteLine("El número ingresado es impar.");
            }
        }
        else
        {
            Console.WriteLine("El valor ingresado no es un número entero válido.");
        }
        Console.WriteLine("Presione cualquier tecla para salir.");
        Console.ReadKey();
    }
}

