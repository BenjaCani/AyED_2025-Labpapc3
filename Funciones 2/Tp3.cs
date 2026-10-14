
using System;

class Program
{
    static void Main(string[] args)
    {
        int num1, num2;

        Console.WriteLine("Ingrese el primer numero:");
        num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo numero:");
        num2 = int.Parse(Console.ReadLine());

        MostrarNumeros(num1, num2);
        ContarPares(num1, num2);
        ContarImpares(num1, num2);
        SumarNumeros(num1, num2);
    }

    static void MostrarNumeros(int num1, int num2)
    {
        int cantidad = 0;

        for (int i = num1 + 1; i < num2; i++)
        {
            Console.WriteLine(i);
            cantidad++;
        }

        Console.WriteLine("Cantidad de numeros: " + cantidad);
    }

    static void ContarPares(int num1, int num2)
    {
        int pares = 0;

        for (int i = num1 + 1; i < num2; i++)
        {
            if (i % 2 == 0)
            {
                pares++;
            }
        }

        Console.WriteLine("Cantidad de pares: " + pares);
    }

    static void ContarImpares(int num1, int num2)
    {
        int impares = 0;

        for (int i = num1 + 1; i < num2; i++)
        {
            if (i % 2 != 0)
            {
                impares++;
            }
        }

        Console.WriteLine("Cantidad de impares: " + impares);
    }

    static void SumarNumeros(int num1, int num2)
    {
        int suma = 0;

        for (int i = num1 + 1; i < num2; i++)
        {
            suma = suma + i;
        }

        Console.WriteLine("La suma es: " + suma);
    }
}
