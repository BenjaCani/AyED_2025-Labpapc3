using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-Lista de Calificaciones-"); 
            Console.WriteLine("A. Exelente");
            Console.WriteLine("B. Bueno");
            Console.WriteLine("C. Regular");
            Console.WriteLine("D. Suficiente");
            Console.WriteLine("F. Reprobado");
            Console.Write("Escribe tu nota correspondiente: ");
            string opciones = Console.ReadLine();

            switch (opciones)
            {
                case "A":
                case "a":
                    Console.WriteLine("Exelente!!");
                    break;
                case "B":
                case "b":
                    Console.WriteLine("Bueno!!");
                    break;
                case "C":
                case "c":
                    Console.WriteLine("Regular!!");
                    break;
                case "D":
                case "d":
                    Console.WriteLine("Suficiente!!");
                    break;
                case "F":
                case "f":
                    Console.WriteLine("Reprobado!");
                    break;

            }



        }
    }
}
