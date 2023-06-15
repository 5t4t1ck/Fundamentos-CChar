using System;

class Program
{
    static void Main()
    {
        double radio, area;

        Console.WriteLine("Ingrese el radio del círculo: ");
        string input = Console.ReadLine();

        if (double.TryParse(input, out radio))
        {
            area = Math.PI * Math.Pow(radio, 2);

            Console.WriteLine("El área del círculo es: " + area);
        }
        else
        {
            Console.WriteLine("El valor ingresado no es válido.");
        }

        Console.ReadLine();
    }
}

