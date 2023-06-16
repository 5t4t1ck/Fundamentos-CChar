// Ciclo For

/*
El ciclo "for" se utiliza para iterar sobre una secuencia de valores o para ejecutar un bloque de código un número 
específico de veces. Consiste en tres partes: la inicialización, la condición y la expresión de actualización. 
La inicialización se ejecuta una vez antes de comenzar el ciclo, la condición se verifica antes de cada iteración 
y la expresión de actualización se ejecuta al final de cada iteración.
*/

// Ejemplo de uso del ciclo "for":
for (int i = 0; i < 5; i++) 
    // La inicialización: i se inicia en 0, la condición: i es menor que 5, la expresión de actualización:
    // incrementa i en 1 en cada iteración
{
    Console.WriteLine("Iteración: " + i);
}

/*
- El ciclo "for" se utiliza cuando se conoce la cantidad exacta de iteraciones o la secuencia de valores que se recorrerá.
- La inicialización establece el valor inicial de la variable de control del ciclo.
- La condición se evalúa antes de cada iteración y determina si el ciclo debe continuar o no.
- Si la condición es verdadera, se ejecuta el bloque de código dentro del "for"; de lo contrario, se sale del ciclo.
- La expresión de actualización se ejecuta al final de cada iteración y generalmente se utiliza para actualizar la variable 
de control del ciclo.
- Es importante asegurarse de que la condición eventualmente se vuelva falsa para evitar ciclos infinitos.
*/

// Ejemplo adicional de uso del ciclo "for":
int resultado = 1;

for (int j = 1; j <= 5; j++) 
// Multiplicación de los números del 1 al 5

{
    resultado *= j; 
    // Multiplica resultado por j en cada iteración
}

Console.WriteLine("El resultado es: " + resultado);

/*
- En este ejemplo, se utiliza el ciclo "for" para realizar la multiplicación de los números del 1 al 5.
- La variable "resultado" se inicializa en 1 y se actualiza en cada iteración multiplicándola por el valor de "j".
- Después de que el ciclo "for" se completa, se imprime el resultado final.
*/