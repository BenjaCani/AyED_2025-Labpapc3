using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {

            do
            {
                Console.Write("Ingresa la nota de tu examen: ");
                int nota = int.Parse(Console.ReadLine());


             while (nota > 10);
            {

                Console.WriteLine("ERROR");

            }
            Console.WriteLine("Nota correcta:"+ nota);
        }
    }
}
