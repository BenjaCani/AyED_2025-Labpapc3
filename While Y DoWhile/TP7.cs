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
            int contador = 1;
            int calculo1 = 0;
            int promedio;
            int nota1 = 0;
            int nota2 = 0;
            int nota3= 0;
            int nota4= 0;
            int nota5= 0;
            do
            {
                
                Console.Write("Ingresa las notas del alumnos: ");
                nota1 = int.Parse(Console.ReadLine());
                contador++;
                Console.Write("Ingresa las notas del alumnos: ");
                nota2 = int.Parse(Console.ReadLine());
                contador++;
                Console.Write("Ingresa las notas del alumnos: ");
                nota3 = int.Parse(Console.ReadLine());
                contador++; 
                Console.Write("Ingresa las notas del alumnos: ");
                nota4 = int.Parse(Console.ReadLine());
                contador++;
                Console.Write("Ingresa las notas del alumnos: ");
                nota5 = int.Parse(Console.ReadLine());
                contador++;
                calculo1 =  nota1 + nota2 + nota3 + nota4 + nota5;
                promedio = calculo1 / 5;
                
                

            } while (contador <= 5);
            {
                Console.Write("Promedio: "+promedio);

            }

        }
    }
}