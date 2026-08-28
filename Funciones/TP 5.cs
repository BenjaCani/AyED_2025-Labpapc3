using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int La_Base = 2;
            Console.Write($"Potencia de {La_Base}:");
            int Exponente = int.Parse(Console.ReadLine());
            ContarRegresivo(La_Base, Exponente);
            
            
        }

        static void ContarRegresivo(int La_Basee, int Exponentee)
        {
            
            for (int i = 1; i <= La_Basee; i++)
            {
                Exponentee *= i;
                
            }
            Console.WriteLine("Suma de los Numeros = "+ Exponentee);
        }

    }
}