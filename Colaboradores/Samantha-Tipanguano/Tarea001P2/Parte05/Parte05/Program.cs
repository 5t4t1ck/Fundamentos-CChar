// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using System.IO;

//Parte 5

//1.Imprimir los números del 1 al 10:
/*class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
    }
}*/

//2.Calcular la suma de los números del 1 al 100:
/*class Program
{
    static void Main(string[] args)
    {
        int suma = 0;

        for (int i = 1; i <= 100; i++)
        {
            suma += i;
        }

        Console.WriteLine("La suma de los números del 1 al 100 es: " + suma);
    }
}*/

//3.Validar la entrada de un número mayor a cero:
/*class Program
{
    static void Main(string[] args)
    {
        int numero;

        do
        {
            Console.WriteLine("Ingrese un número mayor a cero:");
            string input = Console.ReadLine();
            bool esNumero = int.TryParse(input, out numero);

            if (esNumero && numero > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido mayor a cero.");
            }
        } while (true);

        Console.WriteLine("El número ingresado es válido: " + numero);
    }
}*/

//4.Imprimir los caracteres de un string en orden inverso:
/*class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese una palabra o frase:");
        string texto = Console.ReadLine();

        char[] caracteres = texto.ToCharArray();

        Array.Reverse(caracteres);

        Console.WriteLine("El texto en orden inverso es:");
        foreach (char caracter in caracteres)
        {
            Console.Write(caracter);
        }
    }
}*/

//5.Calcular el factorial de un número
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número:");
        int numero = Convert.ToInt32(Console.ReadLine());

        long factorial = CalcularFactorial(numero);

        Console.WriteLine("El factorial de " + numero + " es: " + factorial);
    }

    static long CalcularFactorial(int numero)
    {
        if (numero == 0)
        {
            return 1;
        }
        else
        {
            long factorial = 1;

            for (int i = 1; i <= numero; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}


