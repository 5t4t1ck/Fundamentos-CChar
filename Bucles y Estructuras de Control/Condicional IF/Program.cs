// Sentencia condicional "if"

/*
La sentencia condicional "if" se utiliza para realizar una evaluación condicional en C#. 
Permite ejecutar un bloque de código si se cumple una determinada condición. 
La condición debe ser una expresión que se evalúa como true o false. 
Si la condición es true, el bloque de código dentro del "if" se ejecuta; de lo contrario, 
se pasa al siguiente bloque de código.
*/

// Ejemplo de uso de la sentencia "if":
int edad = 25;

if (edad >= 18) 
// Comprueba si la edad es mayor o igual a 18
{
    Console.WriteLine("Eres mayor de edad."); 
    // Se ejecuta si la condición es verdadera
}

/*
- La sentencia "if" se utiliza para tomar decisiones en función de una condición.
- La condición dentro del "if" debe ser una expresión que se evalúa como true o false.
- Si la condición es true, el bloque de código dentro del "if" se ejecuta.
- Se utiliza la llave de apertura "{" para iniciar el bloque de código del "if" y la llave de cierre "}" para terminarlo.
- Si la condición es false, el bloque de código del "if" se omite y se pasa al siguiente bloque de código.
- Puede haber un solo bloque de código dentro del "if", o se pueden utilizar llaves para agrupar varias líneas de código.
*/

// Ejemplo adicional de uso de la sentencia "if":
int numero = 7;

if (numero % 2 == 0) 
// Comprueba si el número es par verificando si el resto de la división por 2 es cero

{
    Console.WriteLine("El número es par."); 
    // Se ejecuta si la condición es verdadera
}
else
{
    Console.WriteLine("El número es impar."); 
    // Se ejecuta si la condición es falsa
}

