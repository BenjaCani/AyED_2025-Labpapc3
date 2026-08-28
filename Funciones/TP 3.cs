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
            int sumaa = 0;
            Console.WriteLine("Cuenta regresiva:");
            int Numero = int.Parse(Console.ReadLine());
            ContarRegresivo(Numero,sumaa);
            
            
        }

        static void ContarRegresivo(int numero, int suma)
        {
            
            for (int i = 1; i <= numero; i++)
            {
                suma += i;
                Console.WriteLine(i);
            }
            Console.WriteLine("Suma de los Numeros = "+suma);
        }

    }
}