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
            string usuario = "admin";
            int contraseña = 1234;

            Console.WriteLine("Ingrese su Nombre de Usuario: ");
            string UsuarioIngresado = Console.ReadLine();
            Console.WriteLine("Ingrese la Contraseña: ");
            int contraseñap = Convert.ToInt32(Console.ReadLine());

            if (UsuarioIngresado == usuario && contraseñap == contraseña)
            {
                Console.WriteLine("Acceso concedido");
            }
            else
            {
                Console.WriteLine("Error de credencial");
            }
        }
    }
}
