using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    internal class CajeroAutomatico: CuentaBancaria
    {
        public void GenerarPIN()
        {
            Random rnd = new Random();
            Pin = rnd.Next(1000, 10000);
        }

        public int ConsultarPIN()
        {
            return Pin;
        }

        public void CambiarPIN(int nuevoPIN)
        {
            Pin = nuevoPIN;
            Console.WriteLine("CAMBIO EXITOSO DEL PIN");
        }

        //CONSULTAR 
        public double ConsultarSaldo()
        {
            return Saldo;
        }

        //DEPOSITAR 
        public void Depositar(double deposito)
        {
            if (deposito > 0)
            {
                Saldo += deposito;
                Console.WriteLine($"DEPOSITO {deposito} EN LA CUENTA.");
            }
            else
            {
                Console.WriteLine("DEPOSITO INSUFICIENTE");
            }
        }

        //RETIRAR 

        public void Retirar(double retiro)
        {
            if (Saldo > retiro & retiro > 0)
            {
                Saldo -= retiro;
                Console.WriteLine($"RETIRO DE {retiro} ");
            }
            else
            {
                Console.WriteLine("SALDO INSUFICIENTE");
            }

        }
    }
}
