// See https://aka.ms/new-console-template for more information

//Crear un script que calcule el area de un rectangulo 
int base=0;
int altura = 0;

Console.WriteLine("Por favor ingrese un valor");
altura = Convert.ToInt32(Console.Readline());

Console.WriteLine("Por favor ingrese un valor");
base = Convert.ToInt32(Console.Readline());

resultado = altura * base;

Console.Writeline("El resultado es: " + resultado);