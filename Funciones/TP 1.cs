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
            Console.WriteLine("Cuenta regresiva:");
            int Numero = int.Parse(Console.ReadLine());
            ContarRegresivo(Numero);
        }

        static void ContarRegresivo(int numero)
        {
            for (int i = numero; i >= 1; i--)
            {
                Console.WriteLine(i - 1);
            }
        }
    }
}