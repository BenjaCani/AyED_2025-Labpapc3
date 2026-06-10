using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {

            int personas_cant=0;
            int suma_Edad = 0;
            string respuesta = "si" + "Si";
            int mayores = 0;
            int menores = 0;

            do
            {
                Console.WriteLine("Ingrese la edad: ");
                int edad = int.Parse(Console.ReadLine());
                personas_cant++;
                suma_Edad = suma_Edad + edad;
                if (edad >= 18)
                {
                    mayores++;
                }
                else
                {
                    menores++;
                }

                Console.WriteLine("Desea seguir ingresando edades? (si/no) ");
                respuesta = Console.ReadLine();

            } while (respuesta == "si" || respuesta == "Si" );

            float promedio = suma_Edad / personas_cant;
            Console.WriteLine("El promedio de edad de todas las personas registradas: "+promedio);
            Console.WriteLine("Mayores de edad: "+mayores);
            Console.WriteLine("Menores de edad: "+menores);



        }
    }
}
