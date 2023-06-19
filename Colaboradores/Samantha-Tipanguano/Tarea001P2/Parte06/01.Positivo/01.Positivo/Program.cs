// Parte 6
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Verificación de número positivo");
        Console.Write("Ingrese un número: ");
        double numero = Convert.ToDouble(Console.ReadLine());
        if (numero > 0)
        {
            Console.WriteLine("El número ingresado es positivo.");
        }
        else if (numero == 0)
        {
            Console.WriteLine("El número ingresado es cero.");
        }
        else
        {
            Console.WriteLine("El número ingresado es negativo.");
        }
        Console.WriteLine("Presione cualquier tecla para salir.");
        Console.ReadKey();
    }
}

