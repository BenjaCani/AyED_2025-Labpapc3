using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Escribe la nota de tu examen: ");
            int nota = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("Escribe la nota de tu examen: ");
                nota = int.Parse(Console.ReadLine());



            } while (nota > 10);
            {

                Console.Write("Error");


            }
            Console.Write("Escribe la nota de tu examen: ");
        }
    }
}
