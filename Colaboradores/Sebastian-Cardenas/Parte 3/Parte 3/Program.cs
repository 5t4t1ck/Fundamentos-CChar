// See https://aka.ms/new-console-template for more information

//1
int numero = 8;

if (numero % 2 == 0)
{
    Console.WriteLine("El número es par.");
}
else
{
    Console.WriteLine("El número es impar.");
}

//2
int edad = 20;
int edadMayorEdad = 18;

if (edad >= edadMayorEdad)
{
    Console.WriteLine("La persona es mayor de edad.");
}
else
{
    Console.WriteLine("La persona es menor de edad.");
}

//3
bool esEstudianteUniversitario = true;

if (esEstudianteUniversitario)
{
    Console.WriteLine("La persona es estudiante universitario.");
}
else
{
    Console.WriteLine("La persona no es estudiante universitario.");
}

//4
int numero2 = 5;

if (numero2 > 0 && numero2 < 10)
{
    Console.WriteLine("El número es mayor que cero y menor que diez.");
}
else
{
    Console.WriteLine("El número no cumple la condición requerida.");
}

//5
int anio = 2024;

if ((anio % 4 == 0 && anio % 100 != 0) || anio % 400 == 0)
{
    Console.WriteLine("El año es bisiesto.");
}
else
{
    Console.WriteLine("El año no es bisiesto.");
}
