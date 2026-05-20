using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeros;
            int alcancia = 0;
            do
            {
                Console.Write("Guardar en alcancia: ");
                numeros = int.Parse(Console.ReadLine());
                alcancia = alcancia + numeros;
            } while (numeros > 0);
            {
                Console.Write("Total Acumulado: "+ alcancia);


            }
        }
    }
}
