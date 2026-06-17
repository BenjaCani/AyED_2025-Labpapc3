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
            double CreditoActual = 100;
            int apuesta = 1;
            int dado1 = 0;
            int dado2 = 0;
            int suma = 0;

            do
            {
                Console.WriteLine("Credito Total: " + CreditoActual);
                Console.WriteLine("Mi Apuesta ($):");
                apuesta = int.Parse(Console.ReadLine());
                

                if (apuesta < 0 || apuesta > CreditoActual)
                {
                    Console.WriteLine("ERRROR");

                }

                else if (apuesta > 0 || apuesta < CreditoActual)

                {

                    Console.WriteLine("Ingrese el valor del Dado1: ");
                    dado1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el valor del Dado2: ");
                    dado2 = int.Parse(Console.ReadLine());

                    suma = dado1 + dado2;
                   


                    if (suma  == 7 || suma == 11)
                    {
                        apuesta = apuesta * 2;
                        CreditoActual = CreditoActual + apuesta;
                        Console.WriteLine("Haz ganado. Ganaste " + apuesta + "$");
                        
                        
                        


                    }
                    else 
                    {
                        Console.WriteLine("Perdiste. Apuesta perdida");
                        CreditoActual = CreditoActual - apuesta;





                    }



                }
            } while (CreditoActual > 0 || apuesta > 0);

            Console.WriteLine("Saldo Final: " + CreditoActual);

        }
    }
}
