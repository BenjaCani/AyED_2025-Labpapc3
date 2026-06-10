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


            int presentes = 0;
            int ausentes = 0;
            int alumnos_cant = 1;
            string respuesta = "si"+ "Si";

            do
            {
                Console.WriteLine("Nombre del Alumno: ");
                string Nombre_Alum = Console.ReadLine();
                

                Console.WriteLine("Estado: ");
                string Estado = Console.ReadLine();

                if (Estado == "P" || Estado == "p")
                {
                    presentes++;
                    
                    Console.WriteLine("Quiere agregar otro alumno? (si o no)");
                    respuesta = Console.ReadLine();
                    if (respuesta == "si" || Estado == "Si")
                    {
                        alumnos_cant++;

                    }

                }
                else if (Estado == "A" || Estado == "a")
                {
                    ausentes++;
                    Console.WriteLine("Quiere agregar otro alumno? (si o no)");
                    respuesta = Console.ReadLine();
                    if (respuesta == "si" || Estado == "Si")
                    {
                        alumnos_cant++;

                    }
                }
                else
                {
                    Console.WriteLine("ERROR");
                }


            } while (respuesta == "si" || respuesta == "Si" );

            Console.WriteLine("Cantidad de alumnos: " + alumnos_cant);
            Console.WriteLine("Cantidad de presentes: "+presentes);
            Console.WriteLine("Cantidad de ausentes: " +ausentes);
            Console.WriteLine("Porcentaje de Presentismo sobre el total de alumnos: " + 100*(presentes / alumnos_cant)+"%" );




        }
    }
}
