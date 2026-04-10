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
            Console.WriteLine("Ingresa el Presupuesto disponible: ");
            float Press = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el costo de los materiales: ");
            float CostoMateriales = Convert.ToInt32(Console.ReadLine());


            if (CostoMateriales > Press)
            {
                float faltante = CostoMateriales - Press;
                Console.WriteLine("El costo es mayor al presupuesto." + "Faltan " + faltante+ " $." );
            }
            else
            {
                Console.WriteLine("Si alcanza.");
            }

        }
        
    }
}
