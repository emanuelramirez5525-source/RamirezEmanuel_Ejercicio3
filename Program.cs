// 3) Sistema de facturación con control antifraude
Console.WriteLine("MENU");
Console.WriteLine("Presione 1 si es Estudiante");
Console.WriteLine("Presione 2 si es Docente");
Console.WriteLine("Presione 3 si es Administrativo");
Console.WriteLine("Presione 4 si es Externo");

int opcion = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese monto base");
double monto = double.Parse(Console.ReadLine());

Console.WriteLine("Metodo de pago");
Console.WriteLine("1 Efectivo");
Console.WriteLine("2 Tarjeta");
Console.WriteLine("3 Trasnferencia");
int metodo = int.Parse(Console.ReadLine());

Console.WriteLine("Tiene cupon? (S/N)");
string tieneCupon = Console.ReadLine().ToUpper();

int cuponValido = 0;

if (tieneCupon == "S")
{
    Console.WriteLine("Ingrese la primera letra del cupon ");
    string primeraLetra = Console.ReadLine();

    Console.WriteLine("Ingrese el ULTIMO numero del cupon");
    int ultimoNumero = int.Parse(Console.ReadLine());

    if (primeraLetra == "U")
    {
        if (ultimoNumero % 2 == 0)
        {
            cuponValido = 1;
        }
    }
}

Console.WriteLine("REPORTE ANTIFRAUDE");
Console.WriteLine("1 Ninguno");
Console.WriteLine("2 Cupon invalido repetido");
Console.WriteLine("3 Pagos rechazados multiples");

int fraude = int.Parse(Console.ReadLine());

double descuento = 0;
double recargo = 0;

switch (opcion)
{
    case 1:
        if (metodo == 1)
        {
            descuento = monto * 0.10;

        }
        else if (metodo == 2)
        {
            descuento = monto * 0.08;
        }
            break;

    case 2:

        if (metodo == 1)
        {
            descuento = monto * 0.08;
                
        }
        else if (metodo == 2)
        {
            descuento = monto * 0.05;
        }





            break;

    case 3:
        descuento = monto * 0.05;

        break;


    case 4:

        descuento = 0;


        break;

    default:

        Console.WriteLine("Cliente invalido");

        break;
}

if (fraude == 2|| fraude == 3)
{
    if (descuento > 0)
    {
        descuento = 0;
        recargo = monto * 0.12;
    }
}

double total = monto - descuento + recargo;