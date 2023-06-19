// See https://aka.ms/new-console-template for more information

Console.WriteLine("******** Area de un Circulo ********");

Console.WriteLine("Ingrese el radio del circulo: ");
double radio = double.Parse(Console.ReadLine());

double area = Math.PI * Math.Pow(radio, 2);

Console.WriteLine($"El area del circulo es: {area}");

