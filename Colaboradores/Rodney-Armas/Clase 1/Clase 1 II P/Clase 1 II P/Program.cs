// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Hello, World!");

// Crear un script que calcule el area de un rectangulo

double a = 0;
double b = 0;
double resultado = 0;

Console.WriteLine("Por favor ingrese un valor");
a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Por favor ingrese un valor");
b = Convert.ToDouble(Console.ReadLine());

resultado = a * b;

Console.WriteLine("El resultado es: " + resultado);

// Crear un programa para calcular el area de un circulo
// PI * radio * radio

double radio;
double area;

Console.WriteLine("Ingrese el radio del círculo: ");
radio = Convert.ToDouble(Console.ReadLine());

// Calcula el área del círculo
area = Math.PI * Math.Pow(radio, 2);

Console.WriteLine("El área del círculo es: " + area);