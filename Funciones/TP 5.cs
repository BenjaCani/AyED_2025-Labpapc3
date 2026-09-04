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
            /*Desarrollar un programa que permita ingresar una cantidad determinada de números enteros. Al
            finalizar la carga, mostrar el mayor, el menor, el promedio de los valores ingresados y la
            cantidad de números pares e impares.*/

            int cantidad;
            Console.Write("Hola! Cuantos Numeros deseas ingresar? ");
            cantidad =  int.Parse(Console.ReadLine());

            while ()
            {

            }
          
        }

        static void Mayor(int a, int b)
        {
            if (a > b)
            {
                return ;
            }
            else
            {
                return ;
            }

        }
        static void Menor(int a, int b)
        {
            

            if (a < b)
            {
                return ;
            }
            else
            {
                return ;
            }

        }
        static void Promedio(int Cantidad, int parametro, int Promedio)
        {

            Promedio = parametro / Cantidad;
            Console.WriteLine("Promedio Total: ");

        }
        static void Par_Impar(int numero)
        {
           if (numero % 2 == 0)
           {
               Console.WriteLine("Si es par.");
           }
           else
           {
               Console.WriteLine("Es impar");
           }

        }

    }
}
