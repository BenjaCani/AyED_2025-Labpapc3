using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Ingrese un numero entero positivo:");
            numero = int.Parse(Console.ReadLine());

            MostrarSumas(numero);
        }

        static void MostrarSumas(int numero)
        {
            int suma;
            int inicio;
            int cantidad;
            int encontrados = 0;

            for (inicio = 1; inicio < numero; inicio++)
            {
                suma = 0;
                cantidad = 0;

                for (int i = inicio; suma < numero; i++)
                {
                    suma = suma + i;
                    cantidad = cantidad + 1;

                    if (suma == numero && cantidad >= 2)
                    {
                        for (int x = inicio; x < inicio + cantidad; x++)
                        {
                            Console.Write(x);

                            if (x < inicio + cantidad - 1)
                            {
                                Console.Write(" + ");
                            }
                        }

                        Console.WriteLine(" = " + numero);
                        encontrados = 1;
                    }
                }
            }

            if (encontrados == 0)
            {
                Console.WriteLine("No se encontro");
            }
        }
    }
}
