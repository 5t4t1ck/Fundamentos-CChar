// Parte 8

// 1. Imprimir los números del 1 al 10:
Console.WriteLine("1. Imprimir los números del 1 al 10:");

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}


// 2. Calcular la suma de los números del 1 al 100:
Console.WriteLine("\n2. Calcular la suma de los números del 1 al 100:");

int suma = 0;

for (int i = 1; i <= 100; i++)
{
    suma += i;
}
Console.WriteLine("La suma del 1 al 100 es: " + suma);


// 3. Imprimir los caracteres de un string en orden inverso:
Console.WriteLine("\n3. Imprimir los caracteres de un string en orden inverso:");

Console.WriteLine("Ingrese un string: ");
string str = Console.ReadLine();

for (int i = str.Length - 1; i >= 0; i--)
{
    Console.Write(str[i]);
}


// 4. Calcular el factorial de un número:
Console.WriteLine("\n4. Calcular el factorial de un número:");

Console.WriteLine("Ingrese un número: ");
int num = Convert.ToInt32(Console.ReadLine());

int factorial = 1;

for (int i = 1; i <= num; i++)
{
    factorial *= i;
}

Console.WriteLine("El factorial de " + num + " es: " + factorial);


// 5. Obtener los dígitos de un número en orden inverso:
Console.WriteLine("\n5. Obtener los dígitos de un número en orden inverso:");

Console.WriteLine("Ingrese un número: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("El número " + num + " en orden inverso es: ");
while (num > 0)
{
    Console.Write(num % 10);
    num /= 10;
}