//Parte 6
// Verificar si una persona es mayor de edad:

using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese su año de nacimiento: ");
        int anioNacimiento;
        bool isValidAnioNacimiento = int.TryParse(Console.ReadLine(), out anioNacimiento);

        int anioActual = DateTime.Now.Year;
        int edad = anioActual - anioNacimiento;

        if (isValidAnioNacimiento)
        {
            if (edad >= 18)
            {
                Console.WriteLine("Usted es mayor de edad.");
            }
            else
            {
                Console.WriteLine("Usted es menor de edad.");
            }
        }
        else
        {
            Console.WriteLine("El valor ingresado no es un año válido.");
        }
        Console.WriteLine("Presione cualquier tecla para salir.");
        Console.ReadKey();
    }
}
