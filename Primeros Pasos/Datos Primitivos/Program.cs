// Tipos de Datos Primitivos

/*
Este código muestra ejemplos de diferentes tipos de datos primitivos en C#, 
desde tipos numéricos hasta tipos de caracteres y de cadena de texto. 

Cada declaración de variable incluye un comentario explicativo sobre el tipo de dato 
y su rango de valores. Luego, se imprimen los valores de las variables en la consola 
para verificar su funcionamiento.
*/

// Tipo de dato bool
bool esVerdadero = true; 
// Almacena un valor booleano verdadero o falso

// Tipo de dato char
char caracter = 'A'; 
// Almacena un único carácter Unicode

// Tipo de dato byte
byte edad = 25; 
// Almacena números enteros sin signo de 0 a 255

// Tipo de dato sbyte
sbyte temperatura = -10; 
// Almacena números enteros con signo de -128 a 127

// Tipo de dato short
short cantidad = 1000; 
// Almacena números enteros con signo de -32,768 a 32,767

// Tipo de dato ushort
ushort peso = 500; 
// Almacena números enteros sin signo de 0 a 65,535

// Tipo de dato int
int numero = 1000000; 
// Almacena números enteros con signo de -2,147,483,648 a 2,147,483,647

// Tipo de dato uint
uint visitas = 2000000; 
// Almacena números enteros sin signo de 0 a 4,294,967,295

// Tipo de dato long
long poblacion = 7896541230; 
// Almacena números enteros con signo de -9,223,372,036,854,775,808 a 9,223,372,036,854,775,807

// Tipo de dato ulong
ulong cantidadTotal = 18446744073709551615; 
// Almacena números enteros sin signo de 0 a 18,446,744,073,709,551,615

// Tipo de dato float
float temperaturaPromedio = 25.8f; 
// Almacena números de punto flotante de precisión simple

// Tipo de dato double
double altura = 1.85; 
// Almacena números de punto flotante de doble precisión

// Tipo de dato decimal
decimal precio = 19.99m; 
// Almacena números decimales de alta precisión

// Tipo de dato string
string nombre = "John Smith"; 
// Almacena una secuencia de caracteres

// Tipo de dato DateTime
DateTime fechaActual = DateTime.Now; 
// Almacena una fecha y hora

// Tipo de dato TimeSpan
TimeSpan duracion = TimeSpan.FromMinutes(30); 
// Almacena una duración de tiempo

// Tipo de dato object
object objeto = "Hola"; 
// Almacena cualquier tipo de datos

// Tipo de dato var (inferencia de tipos)
var edadUsuario = 30; 
// El tipo de dato se infiere automáticamente según el valor asignado

// Imprimir valores en la consola
Console.WriteLine(esVerdadero);
Console.WriteLine(caracter);
Console.WriteLine(edad);
Console.WriteLine(temperatura);
Console.WriteLine(cantidad);
Console.WriteLine(peso);
Console.WriteLine(numero);
Console.WriteLine(visitas);
Console.WriteLine(poblacion);
Console.WriteLine(cantidadTotal);
Console.WriteLine(temperaturaPromedio);
Console.WriteLine(altura);
Console.WriteLine(precio);
Console.WriteLine(nombre);
Console.WriteLine(fechaActual);
Console.WriteLine(duracion);
Console.WriteLine(objeto);
Console.WriteLine(edadUsuario);
