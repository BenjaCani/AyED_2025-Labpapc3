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
            Console.WriteLine("Escibe una cantidad de Segundos: ");
            int segundos = Convert.ToInt32(Console.ReadLine());

            if (segundos >= 60)
            {
                int minutos = segundos / 60;
                int restoSegundos = segundos % 60;

                Console.WriteLine("Convertidor de Segundos: " + minutos + " minuto " + restoSegundos + " segundos .") ;
            }
            else if (segundos < 60)
            {
                Console.WriteLine(segundos + " segundos" );
            }
        }
    }
}
