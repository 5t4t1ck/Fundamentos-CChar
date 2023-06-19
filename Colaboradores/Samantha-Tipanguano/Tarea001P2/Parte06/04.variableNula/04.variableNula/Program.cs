//Parte 6
// Verificar si una variable es nula:

using System;

class Program
{
    static void Main()
    {
        string variable = null;

        if (variable == null)
        {
            Console.WriteLine("La variable es nula.");
        }
        else
        {
            Console.WriteLine("La variable no es nula.");
        }
        Console.WriteLine("Presione cualquier tecla para salir.");
        Console.ReadKey();
    }
}

