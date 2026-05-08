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
            Console.WriteLine("-Lista de Estaciones del año-");
            Console.WriteLine("1. Primavera");
            Console.WriteLine("2. Verano");
            Console.WriteLine("3. Otoño");
            Console.WriteLine("4. Invierno");
            Console.Write("Escribe tu opcion favorita: ");
            int opciones = int.Parse(Console.ReadLine());

            switch (opciones)
            {
                case 1:
                    Console.WriteLine("Primavera!");
                    break;
                case 2:
                    Console.WriteLine("Verano!");
                    break;
                case 3:
                    Console.WriteLine("Otoño!");
                    break;
                case 4:
                    Console.WriteLine("Invierno!");
                    break;

            }



        }
    }
}
