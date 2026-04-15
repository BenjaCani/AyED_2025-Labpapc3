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
            Console.WriteLine("Escibe tu Promedio: ");
            int promedio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escibe su distancia de casa a la Facultad: ");
            int distancia = Convert.ToInt32(Console.ReadLine());

            if (promedio >= 8 )
            {

                Console.WriteLine("Tienes la Beca Concedida") ;
            }
            else if (distancia >= 50)
            {

                Console.WriteLine("Tienes la Beca Concedida");
            }
            else
            {
                Console.WriteLine("No tienes la Beca" );
            }
        }
    }
}
