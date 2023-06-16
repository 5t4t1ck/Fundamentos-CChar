// Ciclo While

/*
El ciclo "while" se utiliza para repetir un bloque de código mientras se cumpla una condición.
La condición se verifica antes de ejecutar el bloque de código. Si la condición es verdadera,
el bloque de código se ejecuta; de lo contrario, se sale del ciclo.
*/

// Ejemplo de uso del ciclo "while":
int contador = 0;

while (contador < 5) // La condición: el contador es menor que 5
{
    Console.WriteLine("Contador: " + contador);
    contador++; // Incrementa el contador en 1 en cada iteración
}

/*
- El ciclo "while" repite el bloque de código mientras la condición sea verdadera.
- La condición se evalúa antes de ejecutar el bloque de código, por lo que si la condición inicialmente es falsa, 
el bloque de código no se ejecutará.
- Es importante asegurarse de que la condición se actualice dentro del bloque de código para evitar ciclos infinitos.
*/
// Ciclo Do-While
/*
El ciclo "do-while" es similar al ciclo "while", pero la condición se verifica después de ejecutar el bloque de código. 
Esto garantiza que el bloque de código se ejecute al menos una vez, incluso si la condición inicialmente es falsa.
*/

// Ejemplo

int numero;
string entrada;

do
{
    Console.WriteLine("Ingresa un número positivo: ");
    entrada = Console.ReadLine();

} while (!int.TryParse(entrada, out numero) || numero <= 0);

Console.WriteLine("Número válido ingresado: " + numero);

/*
- El ciclo "do-while" ejecuta el bloque de código al menos una vez y luego verifica la condición.
- Si la condición es verdadera, se repite el ciclo y se vuelve a ejecutar el bloque de código.
- En el ejemplo, se utiliza el ciclo "do-while" para solicitar al usuario que ingrese un número positivo. Si el número 
ingresado no es válido (no se puede convertir a un entero o es menor o igual a cero), 
se repite el ciclo hasta que se ingrese un número válido.
- La condición en el "do-while" utiliza el operador de negación "!" para evaluar si el número no se pudo 
convertir a entero o es menor o igual a cero.
*/