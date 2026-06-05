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
            int NumeroFijo = 42;
            int NumeroUsuario = 0;
            int contador = 0;

            Console.WriteLine("Pensando Numero... ");
            Console.WriteLine("HECHO ");
            Console.WriteLine("TIENES 5 INTENTOS ");

            do
            {
            
                Console.WriteLine("Adivina el Numero Chad: ");
                NumeroUsuario= int.Parse(Console.ReadLine());

                if (NumeroUsuario > NumeroFijo) 
                {
                    Console.WriteLine("El Numero es menor ");
                    contador++;


                }
                else if (NumeroUsuario < NumeroFijo) 
                {
                    Console.WriteLine("El Numero es mayor ");
                    contador++;

                }
                else if (NumeroUsuario == NumeroFijo)
                {
                    Console.WriteLine("Haz Acertado!!");
                }
            } while (NumeroFijo != NumeroUsuario && contador < 5);
            Console.WriteLine("--Final del Juego--");
            if (contador == 5)
            {
                Console.WriteLine("Haz Perdido");
            }
            Console.WriteLine("Numero a Adivinar era "+NumeroFijo);
            Console.WriteLine("Intentos "+contador);
            




        }
    }
}
