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
for (int i = texto.Length - 1; i >= 0; i--)
{
    Console.Write(texto[i]);
}
Console.WriteLine();

//4
int numero = 5;
int factorial = 1;
for (int i = 1; i <= numero; i++)
{
    factorial *= i;
}
Console.WriteLine("El factorial de " + numero + " es: " + factorial);

//5
int numero2 = 12345;
int numeroInverso = 0;
while (numero2 > 0)
{
    int digito = numero2 % 10;
    numeroInverso = (numeroInverso * 10) + digito;
    numero2 /= 10;
}
Console.WriteLine("El número en orden inverso es: " + numeroInverso);
