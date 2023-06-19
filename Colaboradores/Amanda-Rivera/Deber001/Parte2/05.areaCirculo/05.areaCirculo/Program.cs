// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Cálculo del Área de un Círculo");


        Console.Write("Ingrese el radio del círculo: ");
        double radio = Convert.ToDouble(Console.ReadLine());

        double area = Math.PI * Math.Pow(radio, 2);

        Console.WriteLine("El área del círculo es: " + area);

        Console.WriteLine("Presione cualquier tecla para salir.");
        Console.ReadKey();
    }
}


