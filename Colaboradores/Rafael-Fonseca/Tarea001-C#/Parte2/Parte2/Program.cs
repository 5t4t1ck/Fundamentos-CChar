// Parte 2

// 1.Saludar a un estudiante de la ESPE, y si es un profesor o directivo, cambia el saludo por algo más respetuoso:
Console.WriteLine("1.Saludar a un estudiante de la ESPE, y si es un profesor o directivo, cambia el saludo por algo más respetuoso:");

Console.WriteLine("Ingrese su nombre: ");
string nombre = Console.ReadLine();

Console.WriteLine("Ingrese su cargo (profesor o directivo): ");
string cargo = Console.ReadLine();
if (cargo == "profesor" || cargo == "directivo")
{
    Console.WriteLine("Buenos días, " + nombre);
}
else
{
    Console.WriteLine("Hola, " + nombre);
}


// 2. Programa para calcular la edad, solicitando el año de nacimiento:
Console.WriteLine("\n2. Programa para calcular la edad, solicitando el año de nacimiento:");

Console.WriteLine("Ingrese su año de nacimiento: ");
int nacimiento = int.Parse(Console.ReadLine());

int edad = 2023 - nacimiento;
Console.WriteLine("Su edad es: " + edad);


// 3. Programa para calcular si una persona está perdida o no en el año lectivo, con rangos de edad específicos:
Console.WriteLine("\n3. Programa para calcular si una persona está perdida o no en el año lectivo, con rangos de edad específicos:");

Console.WriteLine("Ingrese su año edad: ");
int edadP = int.Parse(Console.ReadLine());

if (edadP >= 18 && edadP <= 25)
{
    Console.WriteLine("Usted está perdido");
}
else
{
    Console.WriteLine("Usted no está perdido");
}


// 4. Programa para calcular el área y perímetro de un rectángulo:
Console.WriteLine("\n4. Programa para calcular el área y perímetro de un rectángulo:");

Console.WriteLine("Ingrese la base del rectángulo: ");
int baseRectangulo = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la altura del rectángulo: ");
int alturaRectangulo = int.Parse(Console.ReadLine());

int areaRectangulo = baseRectangulo * alturaRectangulo;
int perimetro = (baseRectangulo * 2) + (alturaRectangulo * 2);

Console.WriteLine("El área del rectángulo es: " + areaRectangulo);
Console.WriteLine("El perímetro del rectángulo es: " + perimetro);

// 5. Programa para calcular el área de un círculo:
Console.WriteLine("\n5. Programa para calcular el área de un círculo:");

Console.WriteLine("Ingrese el radio del círculo: ");
int radio = int.Parse(Console.ReadLine());

double areaCirculo = Math.PI * Math.Pow(radio, 2);

Console.WriteLine("El área del círculo es: " + areaCirculo);
  