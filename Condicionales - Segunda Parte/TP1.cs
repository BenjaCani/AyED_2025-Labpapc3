using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales___Segunda_Parte
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe el Lado a:");
            float LadoA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe el Lado b:");
            float LadoB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe el Lado c:");
            float LadoC = Convert.ToInt32(Console.ReadLine());

            if (LadoA == LadoB && LadoB == LadoC)
            {
                Console.WriteLine("Equilatero");
            }

            else if (LadoA == LadoB)
            {
                Console.WriteLine("Es Isoseles");
            }

            else if (LadoA == LadoC)
            {
                Console.WriteLine("Es isoseles");
            }

            else if (LadoB == LadoA)
            {
                Console.WriteLine("Es Isoseles");
            }

            else if (LadoB == LadoC)
            {
                Console.WriteLine("Es isoseles");
            }

            else if (LadoC == LadoA)
            {
                Console.WriteLine("Es Isoseles");
            }

            else if (LadoC == LadoB)
            {
                Console.WriteLine("Es isoseles");
            }

            else
            {
                Console.WriteLine("Es Escaleno");
            }
        }
    }
}
