// See https://aka.ms/new-console-template for more information
using Lab01;


CajeroAutomatico cajero = new CajeroAutomatico();

int PinAleatorio = cajero.ConsultarPIN();

Console.WriteLine(cajero.ConsultarPIN());

Console.WriteLine("INGRESE PIN: ");

int pin = int.Parse(Console.ReadLine());


if (pin == PinAleatorio)
{
    int opcion = 0;

    while (opcion != 5)
    {
        Console.WriteLine("╔════════════════════════╗");
        Console.WriteLine("║      MENÚ PRINCIPAL    ║");
        Console.WriteLine("╠════════════════════════╣");
        Console.WriteLine("║ 1) Depositar           ║");
        Console.WriteLine("║ 2) Retirar             ║");
        Console.WriteLine("║ 3) Cambiar PIN         ║");
        Console.WriteLine("║ 4) Mostrar Saldo       ║");
        Console.WriteLine("║ 5) Salir               ║");
        Console.WriteLine("╚════════════════════════╝");


        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("MONTO DEL DEPOSITO:");
                double deposito = double.Parse(Console.ReadLine());
                cajero.Depositar(deposito);
                break;
            case 2:
                Console.WriteLine("MONTO DEL RETIRO:");
                double retiro = double.Parse(Console.ReadLine());
                cajero.Retirar(retiro);
                break;
            case 3:
                Console.WriteLine("PIN NUEVO:");
                int nuevoPIN = int.Parse(Console.ReadLine());
                cajero.CambiarPIN(nuevoPIN);
                break;
            case 4:
                Console.WriteLine("SALDO ACTUAL: S/." + cajero.ConsultarSaldo());
                break;
            case 5:
                Console.WriteLine("GRACIAS POR SU TIEMPO");
                break;
            default:
                Console.WriteLine("OPCIÓN INVÁLIDA");
                break;
        }
    }
}
else
{
    Console.WriteLine("PIN incorrecto. Acceso denegado.");
}

//------------------------------------------------------