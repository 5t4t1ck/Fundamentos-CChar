// Operadores aritméticos

/*
Los operadores aritméticos se utilizan para realizar operaciones matemáticas en C#.
Los operadores aritméticos básicos son: suma (+), resta (-), multiplicación (*), división (/) y módulo (%).
Estos operadores se aplican a variables numéricas y producen un resultado basado en la operación realizada.
 */

// Ejemplo de uso de operadores aritméticos:
int a = 10;
int b = 5;

int suma = a + b; // Operador de suma: suma los valores de a y b
int resta = a - b; // Operador de resta: resta el valor de b a a
int multiplicacion = a * b; // Operador de multiplicación: multiplica los valores de a y b
int division = a / b; // Operador de división: divide el valor de a entre b
int modulo = a % b; // Operador de módulo: calcula el residuo de la división de a entre b

Console.WriteLine("Suma: " + suma);
Console.WriteLine("Resta: " + resta);
Console.WriteLine("Multiplicación: " + multiplicacion);
Console.WriteLine("División: " + division);
Console.WriteLine("Módulo: " + modulo);

/*
- Los operadores aritméticos se aplican a variables numéricas del mismo tipo (por ejemplo, int, double).
- La suma se utiliza para sumar dos valores.
- La resta se utiliza para restar un valor de otro.
- La multiplicación se utiliza para multiplicar dos valores.
- La división se utiliza para dividir un valor entre otro. Si los operandos son enteros, la división será 
una división entera y se truncará el residuo decimal.
- El operador de módulo se utiliza para obtener el residuo de una división entera. 
Por ejemplo, el módulo de 10 % 5 es 0, mientras que el módulo de 10 % 3 es 1.
*/

// Ejemplo adicional de uso de operadores aritméticos:
double c = 7.0;
double d = 3.0;

double divisionDecimal = c / d; // División de valores decimales
double potencia = Math.Pow(a, b); // Operador de potencia: eleva a a la potencia de b

Console.WriteLine("División decimal: " + divisionDecimal);
Console.WriteLine("Potencia: " + potencia);