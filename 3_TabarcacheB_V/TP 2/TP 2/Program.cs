using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola usuario");
            Console.Write("¿Cual es tu nombre?: ");
            string nombre = Console.ReadLine();
            Console.Write("¿Cual es tu VideoJuego favorito?: ");
            string juego = Console.ReadLine();
            Console.Write("¿En que consola Jugas?: ");
            string consola = Console.ReadLine();

            Console.WriteLine("Hola " + nombre + "." + "Tu juego favorito es " + juego + " y se juega en " + consola + ".");




        }
    }
}
