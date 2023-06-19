// Parte 2
//Programa para calcular la edad, solicitando el año de nacimiento:
class Program
{
    static void Main()
    {
        Console.Write("Ingrese su año de nacimiento: ");
        int anioNacimiento = Convert.ToInt32(Console.ReadLine());

        int edad = DateTime.Now.Year - anioNacimiento;

        Console.WriteLine("Su edad es: " + edad + " años.");
        Console.WriteLine("Presione cualquier tecla para salir.");
        Console.ReadKey();
    }
}