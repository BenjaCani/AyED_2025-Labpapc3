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
            Console.WriteLine("Indique su sueldo (solo numeros): ");
            double sueldo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Indique Años de Antiguedad (solo numeros): ");
            double AñosAnt = Convert.ToDouble(Console.ReadLine());

            if (AñosAnt > 10)
            {
                double Aumento20 = sueldo * 1.2;
                double SueldoNuevo20 = sueldo + Aumento20;
                Console.WriteLine("Aumento de sueldo 20%: " + SueldoNuevo20);
            }
            else
            {
                double Aumento5 = sueldo * 0.05;
                double SueldoNuevo5 = sueldo + Aumento5;
                Console.WriteLine("Aumento de sueldo 5%: " + SueldoNuevo5);
            }
        }
    }
}
