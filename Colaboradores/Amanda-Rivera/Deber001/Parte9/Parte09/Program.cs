// See https://aka.ms/new-console-template for more information

//Parte 9:

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

//3.Imprimir los caracteres de un string:
/*class Program
{
    static void Main(string[] args)
    {
        string texto = "Hola, mundo!";

        foreach (char caracter in texto)
        {
            Console.WriteLine(caracter);
        }
    }
}*/

//4.Imprimir los números pares del 1 al 20:
/*class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}*/

//5.Calcular el factorial de un número:
class Program
{
    static void Main(string[] args)
    {
        int numero = 8; // El número del cual deseas calcular el factorial
        int factorial = 1;

        for (int i = numero; i >= 1; i--)
        {
            factorial *= i;
        }

        Console.WriteLine("El factorial de " + numero + " es: " + factorial);
    }
}


