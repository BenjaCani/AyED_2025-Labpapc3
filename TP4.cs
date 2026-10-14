
using System;

class Program
{
    static void Main(string[] args)
    {
        int cantidad, numero;
        int positivos = 0, negativos = 0, ceros = 0;
        int sumaPositivos = 0, sumaNegativos = 0;

        Console.WriteLine("Cuantos numeros desea ingresar:");
        cantidad = int.Parse(Console.ReadLine());

        for (int i = 1; i <= cantidad; i++)
        {
            Console.WriteLine("Ingrese un numero:");
            numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                positivos++;
                sumaPositivos = sumaPositivos + numero;
            }
            else if (numero < 0)
            {
                negativos++;
                sumaNegativos = sumaNegativos + numero;
            }
            else
            {
                ceros++;
            }
        }

        ContarPositivos(positivos);
        ContarNegativos(negativos);
        ContarCeros(ceros);
        PromedioPositivos(sumaPositivos, positivos);
        PromedioNegativos(sumaNegativos, negativos);
    }

    static void ContarPositivos(int positivos)
    {
        Console.WriteLine("Cantidad de positivos: " + positivos);
    }

    static void ContarNegativos(int negativos)
    {
        Console.WriteLine("Cantidad de negativos: " + negativos);
    }

    static void ContarCeros(int ceros)
    {
        Console.WriteLine("Cantidad de ceros: " + ceros);
    }

    static void PromedioPositivos(int suma, int cantidad)
    {
        if (cantidad > 0)
        {
            Console.WriteLine("Promedio de positivos: " +
                (double)suma / cantidad);
        }
        else
        {
            Console.WriteLine("No hay numeros positivos.");
        }
    }

    static void PromedioNegativos(int suma, int cantidad)
    {
        if (cantidad > 0)
        {
            Console.WriteLine("Promedio de negativos: " +
                (double)suma / cantidad);
        }
        else
        {
            Console.WriteLine("No hay numeros negativos.");
        }
    }
}
