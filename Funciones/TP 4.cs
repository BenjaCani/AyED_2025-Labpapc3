using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int factorial = 1;
            Console.WriteLine("Cuenta regresiva:");
            int Numero = int.Parse(Console.ReadLine());
            ContarRegresivo(Numero,factorial);
            
            
        }

        static void ContarRegresivo(int numero, int mult)
        {
            
            for (int i = 1; i <= numero; i++)
            {
                mult *= i;
                Console.WriteLine(i);
            }
            Console.WriteLine("Suma de los Numeros = "+ mult);
        }

    }
}