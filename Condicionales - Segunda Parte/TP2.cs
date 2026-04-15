using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales___Segunda_Parte
{
    class Program
    {
 
        static void Main(string[] args)
        {
            Console.WriteLine("Peso: ");
            double Peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Altura: ");
            double Altura = Convert.ToDouble(Console.ReadLine());

            double IMC = Peso / (Altura * Altura);

            if (IMC > 25)
            {
                Console.WriteLine("Sobrepeso");      
            }

            else if (IMC < 25)
            {
                Console.WriteLine("Rango normal");
            }
        }
    }
}
