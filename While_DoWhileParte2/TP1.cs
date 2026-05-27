using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            int SaldoActual = 10000;
            int depositar;
            int retiro;

            while (opcion != 4)
            {
                Console.WriteLine("--Cajero Automatico--");
                Console.WriteLine("-1 Depositar Dinero-");
                Console.WriteLine("-2 Retirar Dinero-");
                Console.WriteLine("-3 Ver Saldo Actual-");
                Console.WriteLine("-4 Salir-");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:

                        Console.Write("Depositar$: ");
                        depositar = int.Parse(Console.ReadLine());
                        SaldoActual = SaldoActual + depositar;
                        Console.WriteLine("Hecho");

                        break;
                    case 2:

                        Console.WriteLine("Retiro: ");
                        retiro = int.Parse(Console.ReadLine());
                        SaldoActual = SaldoActual - retiro;
                        Console.WriteLine("Haz retirado " + retiro + "$.");

                        break;
                    case 3:

                        Console.WriteLine("Saldo Actual");
                        Console.WriteLine(SaldoActual + "$");
                        break;

                    case 4:
                        Console.WriteLine("Saliste del Sistema");
                        break;

                }

            }
        }
    }
}
