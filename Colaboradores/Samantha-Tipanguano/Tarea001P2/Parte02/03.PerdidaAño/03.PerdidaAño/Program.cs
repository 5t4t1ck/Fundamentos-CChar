// Parte 2
//Programa para calcular si una persona está perdida o no en el año lectivo, con
//rangos de edad específicos:

using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Verificar si una persona está perdida en el año lectivo");

        Console.Write("Ingrese el año de nacimiento: ");
        int anioNacimiento = Convert.ToInt32(Console.ReadLine());

        int edad = DateTime.Now.Year - anioNacimiento;

        // Verificar si la persona está perdida en el año lectivo
        if (edad >= 6 && edad <= 17)
        {
            Console.WriteLine("La persona no está perdida en el año lectivo.");
        }
        else
        {
            Console.WriteLine("La persona esta perdida en el año lectivo.");
        }
        Console.WriteLine("Presione cualquier tecla para salir.");
        Console.ReadKey();
    }
}
