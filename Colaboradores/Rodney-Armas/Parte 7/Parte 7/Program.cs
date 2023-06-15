// See https://aka.ms/new-console-template for more information

//1
DateTime fechaActual = DateTime.Now;
DayOfWeek diaSemana = fechaActual.DayOfWeek;

if (diaSemana == DayOfWeek.Saturday || diaSemana == DayOfWeek.Sunday)
{
    Console.WriteLine("Es fin de semana.");
}
else
{
    Console.WriteLine("No es fin de semana.");
}

//2
int mes = fechaActual.Month;

if (mes == 12 || mes == 1 || mes == 2)
{
    Console.WriteLine("Es invierno.");
}
else if (mes >= 3 && mes <= 5)
{
    Console.WriteLine("Es primavera.");
}
else if (mes >= 6 && mes <= 8)
{
    Console.WriteLine("Es verano.");
}
else if (mes >= 9 && mes <= 11)
{
    Console.WriteLine("Es otoño.");
}

//3
DateTime fecha = new DateTime(2023, 6, 14);
string nombreDia = fecha.ToString("dddd");
Console.WriteLine("El día de la semana es: " + nombreDia);

//4
string tipoEmpleado = "Gerente";

if (tipoEmpleado.Equals("Gerente", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("Es un gerente.");
}
else if (tipoEmpleado.Equals("Empleado", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("Es un empleado regular.");
}
else
{
    Console.WriteLine("Es otro tipo de empleado.");
}

//5
string tipoCliente = "Regular";
decimal totalCompra = 100.0m;
decimal descuento = 0.0m;

if (tipoCliente.Equals("Premium", StringComparison.OrdinalIgnoreCase))
{
    descuento = totalCompra * 0.2m;
}
else if (tipoCliente.Equals("Regular", StringComparison.OrdinalIgnoreCase))
{
    descuento = totalCompra * 0.1m;
}

decimal totalConDescuento = totalCompra - descuento;
Console.WriteLine("El total con descuento es: " + totalConDescuento);

