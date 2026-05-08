using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-Lista de Comidas-");
            Console.WriteLine("(S) Sandwich");
            Console.WriteLine("(P) Pizza");
            Console.WriteLine("(H) Hamburguesa");
            Console.Write("Que menu quiere elegir (S-P-H): ");
            string menu = Console.ReadLine();

            switch (menu)
            {
                case "S":
                case "s":
                    Console.WriteLine("Haz elegido Sandwich");
                    break;
                case "P":
                case "p":
                    Console.WriteLine("Haz elegido Pizza");
                    break;
                case "H":
                case "h":
                    Console.WriteLine("Haz elegido Hamburguesa");
                    break;

            }


        }
    }
}
