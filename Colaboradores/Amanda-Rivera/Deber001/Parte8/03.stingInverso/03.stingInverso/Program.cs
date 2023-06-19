//Parte8
//Imprimir los caracteres de un string en orden inverso:

using System;

class Program
{
    static void Main()
    {
        string texto = "Amanda Liliana";
        int longitud = texto.Length;

        for (int i = longitud - 1; i >= 0; i--)
        {
            Console.Write(texto[i]);
        }

        Console.WriteLine();
    }
}
