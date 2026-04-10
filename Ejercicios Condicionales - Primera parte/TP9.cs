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
            Console.WriteLine("Hermano 1 ingrese su edad: ");
            float h1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hermano 2 ingrese su edad: ");
            float h2 = Convert.ToInt32(Console.ReadLine());

            if (h1 > h2)
            {
                Console.WriteLine("El Hermano 1 es mayor que el Hermano 2");
            }
            else
            {
                Console.WriteLine("El Hermano 2 es mayor que el Hermano 1.");
            }

        }
        
    }
}
