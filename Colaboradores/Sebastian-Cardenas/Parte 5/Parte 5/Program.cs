// See https://aka.ms/new-console-template for more information

//1
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

//2
int suma = 0;
for (int i = 1; i <= 100; i++)
{
    suma += i;
}
Console.WriteLine("La suma es: " + suma);

//3
int numero;
do
{
    Console.WriteLine("Ingrese un número mayor a cero:");
    numero = Convert.ToInt32(Console.ReadLine());
} while (numero <= 0);

Console.WriteLine("Número válido: " + numero);

//4
string texto = "Hola mundo";
for (int i = texto.Length - 1; i >= 0; i--)
{
    Console.Write(texto[i]);
}
Console.WriteLine();

//5
int numero2 = 5;
int factorial = 1;
for (int i = 1; i <= numero2; i++)
{
    factorial *= i;
}
Console.WriteLine("El factorial de " + numero2 + " es: " + factorial);

