using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;

            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Ingresa el Numero N°" + i + ":");
                double numero = double.Parse(Console.ReadLine());

                if (numero > 100)
                {
                    contador++;
                }
            }

            Console.Write("Numeros mayor a 100: " + contador);
        }
    }
}
