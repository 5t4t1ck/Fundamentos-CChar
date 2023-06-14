// See https://aka.ms/new-console-template for more information

// Crear un script que calcule el area de un rectangulo

double a = 0;
double b = 0 ;
double resultado = 0;

Console.WriteLine("Por favor ingrese un valor");
a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Por favor ingrese un valor");
b = Convert.ToDouble(Console.ReadLine());

resultado = a * b;

Console.WriteLine("El resultado es: " + resultado);