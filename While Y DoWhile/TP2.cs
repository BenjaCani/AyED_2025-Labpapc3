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


            int nota;

            do
            {
                
                Console.Write("Escribe la nota de tu examen: ");
                nota = int.Parse(Console.ReadLine());
                if (nota > 10)
                    
                {
                    Console.WriteLine("Error ");

                }


            } while (nota > 10);
            {

                Console.Write("Tu nota es correcta:"+nota);


            }
            
        }
    }
}

