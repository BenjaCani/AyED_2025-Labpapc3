
using System;

class Program
{
    static void Main(string[] args)
    {
        int numero;

        Console.WriteLine("Ingrese un numero entero mayor que 1:");
        numero = int.Parse(Console.ReadLine());

        Descomponer(numero);
    }

    static void Descomponer(int numero)
    {
        int divisor = 2;
        int cantidad = 0;

        Console.WriteLine("Factores primos:");

        while (numero > 1)
        {
            if (numero % divisor == 0)
            {
                Console.WriteLine(divisor);
                numero = numero / divisor;
                cantidad++;
            }
            else
            {
                divisor++;
            }
        }

        Console.WriteLine("Cantidad de factores primos: " + cantidad);
    }
}
