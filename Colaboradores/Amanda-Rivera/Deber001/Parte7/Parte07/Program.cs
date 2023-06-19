// See https://aka.ms/new-console-template for more information

//Parte 7:

//1.Verificar el día de la semana:
/*class Program
{
    static void Main(string[] args)
    {
        DayOfWeek diaDeHoy = DateTime.Now.DayOfWeek;

        Console.WriteLine("Hoy es " + ObtenerNombreDiaSemana(diaDeHoy));
    }

    static string ObtenerNombreDiaSemana(DayOfWeek dia)
    {
        switch (dia)
        {
            case DayOfWeek.Sunday:
                return "Domingo";
            case DayOfWeek.Monday:
                return "Lunes";
            case DayOfWeek.Tuesday:
                return "Martes";
            case DayOfWeek.Wednesday:
                return "Miércoles";
            case DayOfWeek.Thursday:
                return "Jueves";
            case DayOfWeek.Friday:
                return "Viernes";
            case DayOfWeek.Saturday:
                return "Sábado";
            default:
                return string.Empty;
        }
    }
}*/

//2.Verificar el mes del año:
/*class Program
{
    static void Main(string[] args)
    {
        int mesActual = DateTime.Now.Month;

        Console.WriteLine("Estamos en el mes de " + ObtenerNombreMes(mesActual));
    }

    static string ObtenerNombreMes(int mes)
    {
        switch (mes)
        {
            case 1:
                return "Enero";
            case 2:
                return "Febrero";
            case 3:
                return "Marzo";
            case 4:
                return "Abril";
            case 5:
                return "Mayo";
            case 6:
                return "Junio";
            case 7:
                return "Julio";
            case 8:
                return "Agosto";
            case 9:
                return "Septiembre";
            case 10:
                return "Octubre";
            case 11:
                return "Noviembre";
            case 12:
                return "Diciembre";
            default:
                return string.Empty;
        }
    }
}*/

//3.Calcular el nombre del día de la semana:
/*class Program
{
    static void Main(string[] args)
    {
        DateTime fechaActual = DateTime.Now;
        string nombreDiaSemana = fechaActual.ToString("dddd");

        Console.WriteLine("Hoy es " + nombreDiaSemana);
    }
}*/

//4.Verificar el tipo de empleado:
/*class Program
{
    static void Main(string[] args)
    {
        string tipoEmpleado = "operario";

        switch (tipoEmpleado.ToLower())
        {
            case "gerente":
                Console.WriteLine("Es un empleado de tipo gerente");
                break;
            case "supervisor":
                Console.WriteLine("Es un empleado de tipo supervisor");
                break;
            case "operario":
                Console.WriteLine("Es un empleado de tipo operario");
                break;
            default:
                Console.WriteLine("Tipo de empleado desconocido");
                break;
        }
    }
}*/

//5.Calcular el descuento según el tipo de cliente:
class Program
{
    static void Main(string[] args)
    {
        string tipoCliente = "regular";
        double montoCompra = 1000;
        double descuento = 0;

        switch (tipoCliente.ToLower())
        {
            case "regular":
                descuento = montoCompra * 0.05;
                break;
            case "vip":
                descuento = montoCompra * 0.10;
                break;
            case "premium":
                descuento = montoCompra * 0.15;
                break;
            default:
                Console.WriteLine("Tipo de cliente desconocido");
                break;
        }

        Console.WriteLine("El descuento para el tipo de cliente " + tipoCliente + " es: $" + descuento);
    }
}


