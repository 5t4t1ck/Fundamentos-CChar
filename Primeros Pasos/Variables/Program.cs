/* 
Variables: 

Una variable es un contenedor con un nombre que se utiliza para almacenar y
hacer referencia a un valor en memoria. En C#, las variables deben ser declaradas
con un tipo de dato específico y luego se les puede asignar un valor. Las variables
pueden contener diferentes tipos de datos, como números, caracteres, cadenas de texto,
booleanos, etc.
*/

// Declaración y asignación de variables:
int edad; 
// Declaración de una variable de tipo entero llamada "edad"

edad = 25; 
// Asignación del valor 25 a la variable "edad"

string nombre = "John Smith"; 
// Declaración y asignación de una variable de tipo cadena de texto llamada "nombre"

double altura = 1.85; 
// Declaración y asignación de una variable de tipo doble llamada "altura"

bool esEstudiante = true; 
// Declaración y asignación de una variable de tipo booleano llamada "esEstudiante"

// Uso de variables:
Console.WriteLine("Nombre: " + nombre);
Console.WriteLine("Edad: " + edad);
Console.WriteLine("Altura: " + altura);
Console.WriteLine("Es estudiante: " + esEstudiante);

// Modificación de variables:
edad = 26; 
// Modificación del valor de la variable "edad"

nombre = "Jane Doe"; 
// Modificación del valor de la variable "nombre"

Console.WriteLine("Nombre actualizado: " + nombre);
Console.WriteLine("Edad actualizada: " + edad);

/*

- Las variables deben ser declaradas antes de su uso y se les puede asignar un valor inicial 
o dejarlas sin valor inicial (en cuyo caso tendrán un valor predeterminado según el tipo de dato).
- Los nombres de las variables deben seguir ciertas reglas, como comenzar con una letra o guión bajo, 
no contener espacios y ser descriptivos.
- El valor de una variable puede ser modificado en cualquier momento a lo largo del programa.
- Las variables tienen un alcance, lo que significa que solo se pueden acceder dentro de la 
porción de código donde se han declarado.

*/

// Ejemplo:

int resultado; 
// Declaración de una variable de tipo entero llamada "resultado"

resultado = edad + 5; 
// Asignación del resultado de una operación aritmética a la variable "resultado"

Console.WriteLine("Resultado: " + resultado);