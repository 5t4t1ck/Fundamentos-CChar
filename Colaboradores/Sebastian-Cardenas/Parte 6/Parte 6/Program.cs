// See https://aka.ms/new-console-template for more information

//1
int numero = 5;

if (numero > 0)
{
    Console.WriteLine("El número es positivo.");
}
else if (numero == 0)
{
    Console.WriteLine("El número es cero.");
}
else
{
    Console.WriteLine("El número es negativo.");
}

//2
int numero2 = 7;

if (numero2 % 2 == 0)
{
    Console.WriteLine("El número es par.");
}
else
{
    Console.WriteLine("El número es impar.");
}

//3
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

//4
string texto = null;

if (texto == null)
{
    Console.WriteLine("La variable es nula.");
}
else
{
    Console.WriteLine("La variable no es nula.");
}

//5
int nota = 75;
int notaAprobacion = 60;

if (nota >= notaAprobacion)
{
    Console.WriteLine("El estudiante aprobó el examen.");
}
else
{
    Console.WriteLine("El estudiante no aprobó el examen.");
}

