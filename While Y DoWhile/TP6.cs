using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese un numero: ");
            int numero = int.Parse(Console.ReadLine());
            int contador = 1;

            while (contador <= numero)
            {
                if (contador % 2 == 0)
                {
                    Console.WriteLine("Numeros Pa: " + contador);

                }
                contador++;
            }
        }
    }
}
