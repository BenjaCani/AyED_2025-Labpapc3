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
            Console.WriteLine("Escribe un Numero: ");
            double N1= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escribe otro Numero: ");
            double N2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escribe otro Numero nuevamente: ");
            double N3 = Convert.ToDouble(Console.ReadLine());
            

            if (N1 > N2 && N1 > N3)
            {
                Console.WriteLine("El Numero " + N1 + " es mayor");
            }
            else if (N2 > N1 && N2 > N3)
            {

                Console.WriteLine("El Numero " + N2 + " es mayor");
            }
            else
            {
                Console.WriteLine("El Numero " + N3 + " es mayor" );
            }
        }
    }
}
