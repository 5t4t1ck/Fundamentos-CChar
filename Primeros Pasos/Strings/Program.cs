// Strings en C#

/* En C#, un string es una secuencia de caracteres utilizada para representar texto. 
 Los strings se declaran utilizando el tipo de datos string y se pueden inicializar 
 con un valor entre comillas dobles (""). Los strings son inmutables, lo que significa 
que no se pueden modificar una vez creados. Sin embargo, se pueden realizar diversas 
operaciones y manipulaciones con strings utilizando métodos y operadores específicos.
*/

// Ejemplo de uso de strings:
string mensaje = "¡Hola, mundo!"; 
// Declaración de un string llamado "mensaje" con el valor "¡Hola, mundo!"

string nombre = "Juan"; 
// Declaración de un string llamado "nombre" con el valor "Juan"

Console.WriteLine(mensaje); 
// Imprime el contenido del string "mensaje"

// Concatenación de strings:
string saludo = "¡Hola, " + nombre + "!"; 
// Concatenación de strings utilizando el operador de suma (+)

Console.WriteLine(saludo); 
// Imprime el contenido del string "saludo"

// Longitud de un string:
int longitud = mensaje.Length; 
// Obtiene la longitud del string "mensaje" utilizando la propiedad Length

Console.WriteLine("Longitud del mensaje: " + longitud);

// Acceso a caracteres individuales:
char primerCaracter = mensaje[0]; 
// Accede al primer carácter del string "mensaje" utilizando el índice 0

Console.WriteLine("Primer carácter del mensaje: " + primerCaracter);

// Comparación de strings:
string texto1 = "Hola";
string texto2 = "Hola";

bool igual = (texto1 == texto2); 
// Operador de igualdad para comparar strings

Console.WriteLine("¿Los strings son iguales?: " + igual);
/*
- Los strings se utilizan para almacenar y manipular texto en C#.
- Se declaran utilizando el tipo de datos string y se inicializan con un valor entre comillas dobles ("").
- Los strings son inmutables, lo que significa que no se pueden modificar una vez creados. 
Cualquier operación que parezca modificar un string en realidad crea un nuevo string con los cambios aplicados.
- La concatenación de strings se realiza utilizando el operador de suma (+).
- La longitud de un string se puede obtener utilizando la propiedad Length.
- Los caracteres individuales de un string se pueden acceder utilizando índices, 
comenzando desde 0.
- Para comparar strings, se utiliza el operador de igualdad (==), que devuelve true si los strings son iguales 
y false en caso contrario.
*/

// Ejemplo adicional de manipulación de strings:
string frase = "El perro juega en el parque";

// Convertir a mayúsculas:
string mayusculas = frase.ToUpper(); 
// Convierte todos los caracteres del string "frase" a mayúsculas

Console.WriteLine("Frase en mayúsculas: " + mayusculas);

// Buscar una subcadena:
bool contiene = frase.Contains("perro"); 
// Verifica si el string "frase" contiene la subcadena "perro"

Console.WriteLine("¿La frase contiene la palabra 'perro'?: " + contiene);

// Reemplazar una subcadena:
string reemplazado = frase.Replace("perro", "gato"); 
// Reemplaza todas las apariciones de "perro" por "gato" en el string "frase"

Console.WriteLine("Frase con reemplazo: " + reemplazado);
