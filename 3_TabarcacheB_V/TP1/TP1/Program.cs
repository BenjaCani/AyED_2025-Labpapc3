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
            string nombre;
            string pelicula;

            Console.WriteLine("Hola Pibe");
            Console.Write("¿Como es tu nombre?: ");
            nombre = Console.ReadLine();
            Console.Write("¿Cual es tu pelicula favorita?: ");
            pelicula = Console.ReadLine();

            Console.WriteLine("Hola " + nombre + "." + "Tu pelicula preferida " + pelicula + " es una porqueria.");



        }
    }
}
