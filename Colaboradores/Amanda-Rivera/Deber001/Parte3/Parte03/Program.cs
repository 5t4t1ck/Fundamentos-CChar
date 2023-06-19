// See https://aka.ms/new-console-template for more information
using System.IO;

//Parte 3:
//Verificar si un número es par:
/*int valor = 17;

if ((valor % 2) == 0)
    Console.WriteLine("Es Par");
else
    Console.WriteLine("Es Impar");*/

//Verificar si una persona es mayor de edad:
/*namespace mayoOmenor
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            Console.WriteLine("Ingresar edad:");
            edad = Convert.ToInt32(Console.ReadLine());

            if (edad>=18)
            {
                Console.WriteLine("Mayor de edad.");
            }else
            {
                Console.WriteLine("Menor de edad");
            }
            Console.WriteLine();
        }
    }
}*/

//Verificar si una persona es estudiante universitario:
/*class Program
{
    static void Main(string[] args)
    {
        // Creamos un diccionario para almacenar los nombres de los estudiantes universitarios
        var estudiantesUniversitarios = new Dictionary<string, bool>
        {
            { "Juan", true },
            { "Camila", true },
            { "Carlos", true }
        };

        // Solicitamos al usuario que ingrese el nombre del estudiante a verificar
        Console.WriteLine("Ingrese el nombre del estudiante:");
        string nombre = Console.ReadLine();

        // Verificamos si el nombre está en el diccionario
        bool esUniversitario = estudiantesUniversitarios.ContainsKey(nombre);

        // Mostramos el resultado
        if (esUniversitario)
        {
            Console.WriteLine("El estudiante es universitario.");
        }
        else
        {
            Console.WriteLine("El estudiante no es universitario o no se encuentra en la lista.");
        }
    }
}*/

//Verificar si un número es mayor que cero y menor que diez:
/*class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número:");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero > 0 && numero < 10)
        {
            Console.WriteLine("El número es mayor que cero y menor que diez.");
        }
        else
        {
            Console.WriteLine("El número no cumple con la condición de ser mayor que cero y menor que diez.");
        }
    }
}*/

//Verificar si un año es bisiesto:
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un año:");
        int año = Convert.ToInt32(Console.ReadLine());

        bool esBisiesto = DateTime.IsLeapYear(año);

        if (esBisiesto)
        {
            Console.WriteLine("El año es bisiesto.");
        }
        else
        {
            Console.WriteLine("El año no es bisiesto.");
        }
    }
}

