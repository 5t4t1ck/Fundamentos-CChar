// Parte 9

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


// 3. Imprimir los caracteres de un string:
Console.WriteLine("\n3. Imprimir los caracteres de un string:");

Console.WriteLine("Ingrese un string: ");
string str = Console.ReadLine();

for (int i = 0; i < str.Length; i++)
{
    Console.WriteLine(str[i]);
}


// 4. Imprimir los números pares del 1 al 20:
Console.WriteLine("\n4. Imprimir los números pares del 1 al 20:");

for (int i = 1; i <= 20; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}


// 5. Calcular el factorial de un número:
Console.WriteLine("\n5. Calcular el factorial de un número:");

Console.WriteLine("Ingrese un número: ");
int num = Convert.ToInt32(Console.ReadLine());

int factorial = 1;

for (int i = 1; i <= num; i++)
{
    factorial *= i;
}

Console.WriteLine("El factorial de " + num + " es: " + factorial);

