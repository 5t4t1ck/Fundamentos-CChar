// See https://aka.ms/new-console-template for more information

// Crear un script que calcula el area de un trian

double b = 0;
double a = 0;
double resultado = 0;

Console.WriteLine("Por favor ingrese un valor");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Por favor ingrese un valor");
b = Convert.ToInt32(Console.ReadLine());

resultado = a * b;

Console.WriteLine("El resultado es: " + resultado);