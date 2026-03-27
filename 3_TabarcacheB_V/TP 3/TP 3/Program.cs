using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola usuario");
            Console.Write("¿Cual es tu año de nacimiento?: ");
            int año = Convert.ToInt32(Console.ReadLine());
            int edad = 2026 - año;

            Console.WriteLine("Si naciste en el año " + año + " y tu edad al comenzar el año es de " + edad + ".");
         
        }
    }
}
