// Parte 6
//Verificar si un estudiante aprobó un examen:
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la calificación del estudiante: ");
        double calificacion = Convert.ToDouble(Console.ReadLine());

        double calificacionMinimaAprobacion = 14.0;

        if (calificacion >= calificacionMinimaAprobacion)
        {
            Console.WriteLine("El estudiante ha aprobado el examen.");
        }
        else
        {
            Console.WriteLine("El estudiante ha reprobado el examen.");
        }
        Console.WriteLine("Presione cualquier tecla para salir.");
        Console.ReadKey();
    }
}
