using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    class Program
    {
        static void Main(string[] args)
        {

            string claveUsuario;
            string claveReal = "1234";

            do
            {
                
                Console.Write("Ingrese la Clave: ");
                claveUsuario = Console.ReadLine();
               


            } while (claveReal != claveUsuario);
            {

                Console.Write("Acceso Permitido");


            }

        }
    }
}