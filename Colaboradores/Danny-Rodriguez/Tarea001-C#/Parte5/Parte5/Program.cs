// Parte 5

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

Console.WriteLine("La suma de los números del 1 al 100 es: " + suma);


// 3. Validar la entrada de un número mayor a cero:
Console.WriteLine("\n3. Validar la entrada de un número mayor a cero:");

int numero = 0;
while (numero <= 0)
{
    Console.WriteLine("Ingrese un número mayor a cero:");
    numero = int.Parse(Console.ReadLine());
}


// 4. Imprimir los caracteres de un string en orden inverso:
Console.WriteLine("\n4. Imprimir los caracteres de un string en orden inverso:");

Console.WriteLine("Ingrese un string:");
string cadena = Console.ReadLine();

for (int i = cadena.Length - 1; i >= 0; i--)
{
    Console.Write(cadena[i]);
}


// 5. Calcular el factorial de un número
Console.WriteLine("\n\n5. Calcular el factorial de un número:");

Console.WriteLine("Ingrese un número:");
int num = int.Parse(Console.ReadLine());

int factorial = 1;
for (int i = 1; i <= num; i++)
{
    factorial *= i;
}

Console.WriteLine("El factorial del número: " + num + " es: " + factorial);
