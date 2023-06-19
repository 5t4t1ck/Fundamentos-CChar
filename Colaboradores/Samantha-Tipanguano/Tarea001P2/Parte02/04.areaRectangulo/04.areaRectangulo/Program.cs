// Parte 2
//Programa para calcular el área y perímetro de un rectángulo:

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Cálculo de Área y Perímetro de un Rectángulo");

        Console.Write("Ingrese el ancho del rectángulo: ");
        double ancho = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la altura del rectángulo: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        double area = ancho * altura;
        double perimetro = 2 * (ancho + altura);

        Console.WriteLine("El área del rectángulo es: " + area);
        Console.WriteLine("El perímetro del rectángulo es: " + perimetro);
        Console.ReadKey();
    }
}

