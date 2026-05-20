using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tabla de Multiplicar del N°");
            int numero = int.Parse(Console.ReadLine());
            int contador = 0;

            while (contador <= 12)
            {
                Console.WriteLine(numero + " x " + contador);
                int calculo = numero * contador;
                contador++;
            }

        }
    }
}
