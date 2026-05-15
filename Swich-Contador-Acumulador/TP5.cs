using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa un número: ");
        int numero = int.Parse(Console.ReadLine());

        int divisores = 0;
        for (int i = 1; i <= numero; i++)
        {
            if (numero % i == 0)
            {
                divisores++;
            }
        }

        if (divisores == 2)
        {
            Console.WriteLine("Es primo");
        }
        if (divisores != 2)
        {
            Console.WriteLine("No es primo");
        }
    }
}
