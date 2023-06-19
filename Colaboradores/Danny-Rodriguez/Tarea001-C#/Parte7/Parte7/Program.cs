// Parte 7

// 1. Verificar el día de la semana:
Console.WriteLine("1. Verificar el día de la semana:");

DateTime currentDayWeek = DateTime.Now;
string diaSemana = currentDayWeek.DayOfWeek.ToString();
Console.WriteLine("El día de la semana es: " + diaSemana);


// 2. Verificar el mes del año:
Console.WriteLine("\n2. Verificar el mes del año:");

DateTime currentMonth = DateTime.Now;
string mes = currentMonth.ToString("MMMM");
Console.WriteLine("El mes actual es: " + mes);


// 3. Calcular el nombre del día de la semana:
Console.WriteLine("\n3. Calcular el nombre del día de la semana:");

DateTime currentDay = DateTime.Now;
string dia = currentDay.ToString("dddd");
Console.WriteLine("El día de la semana es: " + dia);


// 4. Verificar el tipo de empleado:
Console.WriteLine("\n4. Verificar el tipo de empleado:");

Console.WriteLine("Ingrese el tipo de empleado (Gerente, Supervisor, Administrativo, Operario):");
string tipoEmpleado = Console.ReadLine();

switch (tipoEmpleado)
{
    case "Gerente":
        Console.WriteLine("El empleado es de tipo Gerente");
        break;
    case "Supervisor":
        Console.WriteLine("El empleado es de tipo Supervisor");
        break;
    case "Administrativo":
        Console.WriteLine("El empleado es de tipo Administrativo");
        break;
    case "Operario":
        Console.WriteLine("El empleado es de tipo Operario");
        break;
    default:
        Console.WriteLine("El empleado es de tipo Otro");
        break;
}


// 5. Calcular el descuento según el tipo de cliente:
Console.WriteLine("\n5. Calcular el descuento según el tipo de cliente:");

Console.WriteLine("Ingrese el tipo de cliente (Regular, Premium, VIP):");
string tipoCliente = Console.ReadLine();

Double descuentoRegular = 0.05;
Double descuentoPremium = 0.2;
Double descuentoVIP = 0.35;

switch (tipoCliente)
{
    case "Regular":
        Console.WriteLine("El descuento es de:" + descuentoRegular * 100 + "%");
        break;
    case "Premium":
        Console.WriteLine("El descuento es de:" + descuentoPremium * 100 + "%");
        break;
    case "VIP":
        Console.WriteLine("El descuento es de:" + descuentoVIP * 100 + "%");
        break;
    default:
        Console.WriteLine("El descuento es de: 0%");
        break;
}