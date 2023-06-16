// See https// Operadores relacionales

/*
Los operadores relacionales se utilizan para comparar dos valores y determinar la relación entre ellos en C#.
Los operadores relacionales devuelven un valor booleano (true o false)
según si la comparación es verdadera o falsa.
*/

// Ejemplo de uso de operadores relacionales:

int a = 10;
int b = 5;

bool igual = (a == b); 
// Operador de igualdad: verifica si a es igual a b

bool distinto = (a != b); 
// Operador de desigualdad: verifica si a es diferente de b

bool mayor = (a > b); 
// Operador de mayor que: verifica si a es mayor que b

bool menor = (a < b); 
// Operador de menor que: verifica si a es menor que b

bool mayorIgual = (a >= b); 
// Operador de mayor o igual que: verifica si a es mayor o igual que b

bool menorIgual = (a <= b); 
// Operador de menor o igual que: verifica si a es menor o igual que b

Console.WriteLine("Igual: " + igual);
Console.WriteLine("Distinto: " + distinto);
Console.WriteLine("Mayor: " + mayor);
Console.WriteLine("Menor: " + menor);
Console.WriteLine("Mayor o igual: " + mayorIgual);
Console.WriteLine("Menor o igual: " + menorIgual);

/*
- Los operadores relacionales se utilizan para comparar valores y determinar si son iguales, diferentes, mayores o menores.
- El operador de igualdad (==) verifica si dos valores son iguales y devuelve true si lo son, y false en caso contrario.
- El operador de desigualdad (!=) verifica si dos valores son diferentes y devuelve true si lo son, y false en caso contrario.
- Los operadores mayor que (>), menor que (<), mayor o igual que (>=) y menor o igual que (<=) se utilizan para comparar 
valores numéricos y devuelven true o false según la relación entre los valores.
- Los operadores relacionales también se pueden utilizar con tipos de datos distintos a los numéricos, 
como strings, para comparar el orden lexicográfico de los valores.
*/
// Ejemplo
string cadena1 = "Hola";
string cadena2 = "Hola Mundo";

bool comparacion = (cadena1 == cadena2); 
// Comparación de strings usando el operador de igualdad

Console.WriteLine("Comparación de strings: " + comparacion);
