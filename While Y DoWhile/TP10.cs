using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
            int B;
            int resultado = 0;
            int contador = 0;

            Console.Write("Ingrese el primer numero: ");
            A = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo numero: ");
            B = int.Parse(Console.ReadLine());

            while (contador < B)
            {
                resultado = resultado + A;
                contador = contador + 1;
            }

            Console.WriteLine("El resultado de la multiplicacion es: " + resultado);
        }
    }
}
