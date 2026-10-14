
using System;

class Program
{
    static void Main(string[] args)
    {
        int cantidad;

        Console.WriteLine("Cuantos numeros desea ingresar?");
        cantidad = int.Parse(Console.ReadLine());

        int[] numeros = new int[cantidad];

        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine("Ingrese un numero:");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        BuscarRepetidos(numeros, cantidad);
    }

    static void BuscarRepetidos(int[] numeros, int cantidad)
    {
        int mayor = 0;
        int repetidos;

        for (int i = 0; i < cantidad; i++)
        {
            repetidos = 0;

            for (int j = 0; j < cantidad; j++)
            {
                if (numeros[i] == numeros[j])
                {
                    repetidos++;
                }
            }

            if (repetidos > mayor)
            {
                mayor = repetidos;
            }
        }

        Console.WriteLine("Numeros que mas se repiten:");

        for (int i = 0; i < cantidad; i++)
        {
            repetidos = 0;

            for (int j = 0; j < cantidad; j++)
            {
                if (numeros[i] == numeros[j])
                {
                    repetidos++;
                }
            }

            if (repetidos == mayor)
            {
                int encontrado = 0;

                for (int j = 0; j < i; j++)
                {
                    if (numeros[i] == numeros[j])
                    {
                        encontrado = 1;
                    }
                }

                if (encontrado == 0)
                {
                    Console.WriteLine("Numero: " + numeros[i]);
                    Console.WriteLine("Veces que aparece: " + repetidos);
                }
            }
        }
    }
}
