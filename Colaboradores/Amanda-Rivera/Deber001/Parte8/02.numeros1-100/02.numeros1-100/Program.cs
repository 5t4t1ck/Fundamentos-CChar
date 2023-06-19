// Parte 8
//Calcular la suma de los números del 1 al 100:
using System;

class Program
{
    static void Main()
    {
        int suma = 0;

        for (int i = 1; i <= 100; i++)
        {
            suma += i;
        }

        Console.WriteLine("La suma de los números del 1 al 100 es: " + suma);
    }
}

