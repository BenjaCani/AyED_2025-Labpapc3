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
            int contador = 0;
            double promedio;
            int suma=0;
            int nota;
            do
            {

                Console.Write("Ingresa las notas del alumnos: ");
                nota = int.Parse(Console.ReadLine());
                contador++;
                suma = suma + nota;

                Console.WriteLine("Suma Total="+suma);
                Console.WriteLine("Cantidad de Numeros ingresados:"+contador);
                promedio = suma / contador;




            } while (contador < 5);
            {
                Console.WriteLine("--Calculo de Promedio = "+suma+" / "+contador+"--");
                Console.Write("Promedio: " + promedio);

            }

        }
    }
}
