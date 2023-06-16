// See https://aka.ms/new-console-template for more information

//1
string nombre = "Juan";
bool esEstudiante = true;
bool esProfesor = false;
bool esDirectivo = false;

if (esEstudiante)
{
    Console.WriteLine("Hola estudiante " + nombre + " de la ESPE.");
}
else if (esProfesor || esDirectivo)
{
    Console.WriteLine("Saludos respetuosos, " + nombre + ".");
}

//2
Console.WriteLine("Ingrese el año de nacimiento:");
int anioNacimiento = Convert.ToInt32(Console.ReadLine());

int anioActual = DateTime.Now.Year;
int edad = anioActual - anioNacimiento;

Console.WriteLine("Tu edad es: " + edad);

//3
Console.WriteLine("Ingrese su edad:");
int edad2 = Convert.ToInt32(Console.ReadLine());

if (edad2 >= 6 && edad2 <= 18)
{
    Console.WriteLine("Estás en edad escolar. No estás perdido en el año lectivo.");
}
else
{
    Console.WriteLine("Estás fuera de la edad escolar. Es posible que estés perdido en el año lectivo.");
}

//4
double a = 0;
double b = 0;
double resultado = 0;

Console.WriteLine("Por favor ingrese un valor");
a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Por favor ingrese un valor");
b = Convert.ToDouble(Console.ReadLine());

resultado = a * b;

Console.WriteLine("El resultado es: " + resultado);

//5

double radio;
double area;

Console.WriteLine("Ingrese el radio del círculo: ");
radio = Convert.ToDouble(Console.ReadLine());
area = Math.PI * Math.Pow(radio, 2);

Console.WriteLine("El área del círculo es: " + area);


