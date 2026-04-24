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
            Console.WriteLine("Indique si es F o M (Femenino o Masculino): ");
            string genero = Console.ReadLine();
            Console.WriteLine("Indique su Edad: ");
            double edad = Convert.ToDouble(Console.ReadLine());

            if ( genero == "F" && edad >= 65 )
            {
                Console.WriteLine("Puede iniciar el trámite jubilatorio");
            }
            else if ( genero == "M" && edad >= 65)
            {
                Console.WriteLine("Puede iniciar el trámite jubilatorio");
            }

            else
            {
                Console.WriteLine("No puedes Iniciar el Tramite jubilatorio");
            }
        }
    }
}
