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
string texto = "Hola mundo";
foreach (char c in texto)
{
    Console.WriteLine(c);
}

//4
for (int i = 1; i <= 20; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}

//5
int numero = 5;
int factorial = 1;
for (int i = 1; i <= numero; i++)
{
    factorial *= i;
}
Console.WriteLine("El factorial de " + numero + " es: " + factorial);