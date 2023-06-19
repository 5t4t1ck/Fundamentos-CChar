// Parte 6

// 1. Verificar si un número es positivo:
Console.WriteLine("1. Verificar si un número es positivo:");

Console.WriteLine("Ingrese un número:");
int numero = int.Parse(Console.ReadLine());

if (numero > 0)
{
    Console.WriteLine("El número es positivo");
}
else
{
    Console.WriteLine("El número es negativo");
}


// 2. Verificar si un número es par o impar:
Console.WriteLine("\n2. Verificar si un número es par o impar:");

Console.WriteLine("Ingrese un número:");
int num = int.Parse(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("El número es par");
}
else
{
    Console.WriteLine("El número es impar");
}


// 3. Verificar si una persona es mayor de edad:
Console.WriteLine("\n3. Verificar si una persona es mayor de edad:");

Console.WriteLine("Ingrese su edad:");
int edad = int.Parse(Console.ReadLine());

if (edad >= 18)
{
    Console.WriteLine("Usted es mayor de edad");
}
else
{
    Console.WriteLine("Usted es menor de edad");
}


// 4. Verificar si una variable es nula:
Console.WriteLine("\n4. Verificar si una variable es nula:");
string myString = null;
if (myString == null)
{
    Console.WriteLine("La variable es null");
}
else
{
    Console.WriteLine("La variable no es null");
}

// 5. Verificar si un estudiante aprobó un examen:
Console.WriteLine("\n5. Verificar si un estudiante aprobó un examen:");

Console.WriteLine("Ingrese su nota:");
int nota = int.Parse(Console.ReadLine());

if (nota >= 14)
{
    Console.WriteLine("Usted aprobó el examen");
}
else
{
    Console.WriteLine("Usted reprobó el examen");
}