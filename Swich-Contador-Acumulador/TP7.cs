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
            Console.WriteLine("-Lista de Idiomas-");
            Console.WriteLine("(1) Ingles");
            Console.WriteLine("(2) Frances");
            Console.WriteLine("(3) Aleman");
            Console.Write("Que idioma eliges: ");
            string idioma = Console.ReadLine();

            switch (idioma)
            {
                case "1":
                
                    Console.WriteLine("Hello");
                    break;
                case "2":
                
                    Console.WriteLine("Salut");
                    break;
                case "3":
                
                    Console.WriteLine("Hallo");
                    break;

            }


        }
    }
}
