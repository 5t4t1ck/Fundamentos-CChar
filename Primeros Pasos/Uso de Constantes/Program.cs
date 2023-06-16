// Uso de constantes

// Concepto general:
// Una constante es un valor que no puede cambiar una vez que se le asigna. En C#, se pueden declarar constantes utilizando la palabra reservada "const". Las constantes deben ser inicializadas con un valor y su valor no puede ser modificado posteriormente en el programa.

// Declaración y uso de constantes:
const int EdadMaxima = 100; // Declaración de una constante de tipo entero llamada "EdadMaxima" con valor 100

const double Pi = 3.14159; // Declaración de una constante de tipo double llamada "Pi" con valor 3.14159

const string Saludo = "¡Hola, mundo!"; // Declaración de una constante de tipo string llamada "Saludo" con valor "¡Hola, mundo!"

Console.WriteLine("Edad máxima permitida: " + EdadMaxima);
Console.WriteLine("Valor de Pi: " + Pi);
Console.WriteLine("Mensaje de saludo: " + Saludo);

// Intento de modificación de una constante (generará un error en tiempo de compilación):
// EdadMaxima = 99; // Comentar esta línea para evitar el error de compilación

// Comentarios adicionales:
// - Las constantes se utilizan cuando se desea asignar un valor que se mantendrá invariable a lo largo del programa.
// - Las constantes se escriben en mayúsculas por convención para distinguirlas de las variables.
// - No se puede asignar un nuevo valor a una constante después de su declaración inicial. Cualquier intento de modificar una constante generará un error en tiempo de compilación.
// - Las constantes son útiles para representar valores fijos y predecibles, como constantes matemáticas, valores máximos o mínimos, o valores constantes utilizados en cálculos o algoritmos.

// Ejemplo adicional de uso de constantes en una operación:
const double Radio = 5.0; // Declaración de una constante de tipo double llamada "Radio" con valor 5.0

double area = Pi * Radio * Radio; // Cálculo del área de un círculo utilizando la constante "Pi" y la constante "Radio"

Console.WriteLine("Área del círculo: " + area);
