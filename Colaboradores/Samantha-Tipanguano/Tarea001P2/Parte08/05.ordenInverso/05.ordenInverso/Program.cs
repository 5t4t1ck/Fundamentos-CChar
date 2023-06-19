// Parte8
//Obtener los dígitos de un número en orden inverso:
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        string numeroCadena = numero.ToString();
        int longitud = numeroCadena.Length;

        for (int i = longitud - 1; i >= 0; i--)
        {
            int digito = Convert.ToInt32(numeroCadena[i].ToString());
            Console.Write(digito + " ");
        }

        Console.WriteLine();
    }
}
