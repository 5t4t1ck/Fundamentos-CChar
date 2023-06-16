// Sentencia condicional "switch"

/*
// La sentencia condicional "switch" se utiliza para realizar una selección múltiple basada en el valor de una expresión. 
Permite ejecutar diferentes bloques de código según el valor de la expresión evaluada. 
Cada bloque de código se asocia con un valor específico y se ejecuta si ese valor coincide con el valor de la expresión. 
Si ninguno de los valores coincide, se puede incluir un bloque de código opcional "default" que se ejecutará en caso de no 
haber coincidencias.

*/
// Ejemplo de uso de la sentencia "switch":
int diaSemana = 3;
string nombreDia;

switch (diaSemana)
{
    case 1:
        nombreDia = "Lunes";
        break;
    case 2:
        nombreDia = "Martes";
        break;
    case 3:
        nombreDia = "Miércoles";
        break;
    case 4:
        nombreDia = "Jueves";
        break;
    case 5:
        nombreDia = "Viernes";
        break;
    case 6:
        nombreDia = "Sábado";
        break;
    case 7:
        nombreDia = "Domingo";
        break;
    default:
        nombreDia = "Día inválido";
        break;
}

Console.WriteLine("El día de la semana es: " + nombreDia);

/*
- La sentencia "switch" se utiliza para realizar una selección múltiple basada en el valor de una expresión.
- Se utiliza la palabra clave "switch" seguida de la expresión que se va a evaluar.
- Dentro del "switch", se definen diferentes casos (cláusulas "case") que contienen un valor específico con el cual 
se comparará la expresión.
- Si el valor de la expresión coincide con uno de los casos, se ejecuta el bloque de código asociado a ese caso.
- Cada caso debe finalizar con la palabra clave "break" para salir del "switch" y evitar que se ejecuten los casos siguientes.
- Se puede incluir un caso "default" opcional que se ejecutará si ninguno de los casos anteriores coincide con el valor de 
la expresión.
- Si no se incluye un caso "default" y no hay coincidencias, no se ejecutará ningún bloque de código dentro del "switch".
*/

// Ejemplo adicional de uso de la sentencia "switch":

char operador = '+';
int num1 = 10;
int num2 = 5;
int resultado;

switch (operador)
{
    case '+':
        resultado = num1 + num2;
        break;
    case '-':
        resultado = num1 - num2;
        break;
    case '*':
        resultado = num1 * num2;
        break;
    case '/':
        resultado = num1 / num2;
        break;
    default:
        Console.WriteLine("Operador inválido");
        return;
}
`
Console.WriteLine("El resultado es: " + resultado);
