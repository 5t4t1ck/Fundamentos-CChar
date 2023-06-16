// La palabra reservada Var.

/*
En C#, la palabra reservada "var" se utiliza para declarar variables con una inferencia de tipos. 

Esto significa que el compilador determinará automáticamente el tipo de dato de la variable en 
función del valor al que se le asigne.
*/

// Uso de la palabra reservada var:

var edad = 25; 
// El compilador infiere que la variable "edad" es de tipo int debido al valor asignado (25)

var nombre = "John Smith"; 
// El compilador infiere que la variable "nombre" es de tipo string debido al valor asignado ("John Smith")

var altura = 1.85; 
// El compilador infiere que la variable "altura" es de tipo double debido al valor asignado (1.85)

var esEstudiante = true; 
// El compilador infiere que la variable "esEstudiante" es de tipo bool debido al valor asignado (true)

// Uso de variables con inferencia de tipos:
Console.WriteLine("Nombre: " + nombre);
Console.WriteLine("Edad: " + edad);
Console.WriteLine("Altura: " + altura);
Console.WriteLine("Es estudiante: " + esEstudiante);

// Modificación de variables con inferencia de tipos:

edad = 26; 
// La variable "edad" ahora tiene un nuevo valor y sigue siendo de tipo int

nombre = "Jane Doe"; 
// La variable "nombre" ahora tiene un nuevo valor y sigue siendo de tipo string

Console.WriteLine("Nombre actualizado: " + nombre);
Console.WriteLine("Edad actualizada: " + edad);

/*
- La palabra reservada "var" es útil cuando el tipo de dato se puede inferir fácilmente del valor asignado, 
lo que hace que el código sea más conciso y legible.
- Aunque la inferencia de tipos puede ser conveniente, es importante tener en cuenta que se debe proporcionar 
un valor inicial para que el compilador pueda determinar el tipo correctamente.
- La inferencia de tipos no significa que las variables se vuelvan dinámicas; 
una vez que se ha asignado un tipo, la variable se comportará como tal y no se puede cambiar a otro tipo.
- Es recomendable utilizar "var" cuando el tipo de dato es obvio o cuando el código es más claro al evitar 
repetir el tipo de dato en varias declaraciones.
*/

// Ejemplo adicional de uso de var:

var resultado = edad + 5; 
// El compilador infiere que la variable "resultado" es de tipo int debido a la operación aritmética

Console.WriteLine("Resultado: " + resultado);