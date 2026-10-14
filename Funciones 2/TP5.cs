
using System;

class Program
{
    static void Main(string[] args)
    {
        int cantidad, numero;
        int mayor = 0, segundo = 0;
        int contador = 0;

        Console.WriteLine("Cuantos numeros desea ingresar?");
        cantidad = int.Parse(Console.ReadLine());

        for (int i = 1; i <= cantidad; i++)
        {
            Console.WriteLine("Ingrese un numero:");
            numero = int.Parse(Console.ReadLine());

            if (i == 1)
            {
                mayor = numero;
            }
            else
            {
                if (numero > mayor)
                {
                    segundo = mayor;
                    mayor = numero;
                    contador = 1;
                }
                else if (numero < mayor)
                {
                    if (contador == 0 || numero > segundo)
                    {
                        segundo = numero;
                        contador = 1;
                    }
                }
            }
        }

        MostrarResultado(contador, segundo);
    }

    static void MostrarResultado(int contador, int segundo)
    {
        if (contador == 1)
        {
            Console.WriteLine("El segundo numero mas grande es: " + segundo);
        }
        else
        {
            Console.WriteLine("No existe un segundo valor diferente al mayor.");
        }
    }
}
