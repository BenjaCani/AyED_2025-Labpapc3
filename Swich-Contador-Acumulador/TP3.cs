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
            double ahorrado = 0;

            for (int i = 1; i <= 4; i++)
            {
                Console.Write("Guardar: ");
                double ahorro = double.Parse(Console.ReadLine());
                ahorrado = ahorrado + ahorro;
                Console.WriteLine("Ahorrados: "+ahorrado);



            }

        }
    }

}

