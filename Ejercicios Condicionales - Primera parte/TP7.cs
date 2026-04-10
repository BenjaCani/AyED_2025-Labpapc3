using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {          
            Console.WriteLine("Ingrese la temperatura actual: ");
            float temperatura = Convert.ToInt32(Console.ReadLine());

            if (temperatura<0)
            {
                Console.WriteLine("Peligro de Congelamiento");
            }
            else if (temperatura > 0 && temperatura < 15)
            {
                Console.WriteLine("Mucho Frio");
            }
            else
            {
                Console.WriteLine("Clima Agradable");
            }

        }
        
    }
}
