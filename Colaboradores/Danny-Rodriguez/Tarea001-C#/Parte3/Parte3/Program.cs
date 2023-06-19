// Parte 3

// 1. Verificar si un número es par:
Console.WriteLine("1. Verificar si un número es par:");

Console.WriteLine("Ingrese un número: ");
int numero = int.Parse(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine("El número es par");
}
else
{
    Console.WriteLine("El número es impar");
}


// 2. Verificar si una persona es mayor de edad:
Console.WriteLine("\n2. Verificar si una persona es mayor de edad:");

Console.WriteLine("Ingrese su edad: ");
int edad = int.Parse(Console.ReadLine());

if (edad >= 18)
{
    Console.WriteLine("Usted es mayor de edad");
}
else
{
    Console.WriteLine("Usted es menor de edad");
}


// 3. Verificar si una persona es estudiante universitario:
Console.WriteLine("\n3. Verificar si una persona es estudiante universitario:");

Console.WriteLine("¿Es usted estudiante universitario? (si/no)");
string respuesta = Console.ReadLine();

if (respuesta == "si")
{
    Console.WriteLine("Usted es estudiante universitario");
}
else
{
    Console.WriteLine("Usted no es estudiante universitario");
}


// 4. Verificar si un número es mayor que cero y menor que diez:
Console.WriteLine("\n4. Verificar si un número es mayor que cero y menor que diez:");

Console.WriteLine("Ingrese un número: ");
int num = int.Parse(Console.ReadLine());

if (num > 0 && num < 10)
{
    Console.WriteLine("El número es mayor que cero y menor que diez");
}
else
{
    Console.WriteLine("El número no es mayor que cero y menor que diez");
}


// 5. Verificar si un año es bisiesto:
Console.WriteLine("\n5. Verificar si un año es bisiesto:");

Console.WriteLine("Ingrese un año: ");
int year = int.Parse(Console.ReadLine());

if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
{
    Console.WriteLine("El año es bisiesto");
}
else
{
    Console.WriteLine("El año no es bisiesto");
}