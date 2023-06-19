// Parte 2
//Saludar a un estudiante de la ESPE, y si es un profesor o directivo, cambia el saludo por algo
//más respetuoso:
string nombre = "Amanda"; // Nombre de la persona
bool esEstudiante = true; // Variable que indica si es estudiante 

if (esEstudiante)
{
    Console.WriteLine("¡Hola estudiante de la ESPE, " + nombre + "!");
}
else
{
    Console.WriteLine("Buen día, respetable " + nombre + ".");
}

