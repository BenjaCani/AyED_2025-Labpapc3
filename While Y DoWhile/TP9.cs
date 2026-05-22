using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;

            while (opcion != 3)
            {
                Console.WriteLine("-MENU-");
                Console.WriteLine("1)Saludar");
                Console.WriteLine("2)Despedirse");
                Console.WriteLine("3)Salir");

                Console.Write("Elije una opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:

                        Console.WriteLine("Holaa");
                        break;
                    case 2:

                        Console.WriteLine("Chau");
                        break;
                    case 3:

                        Console.WriteLine("salir");
                        break;

                }
            }

        }
    } 
}
