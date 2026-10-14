
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

        MostrarPrimos(num1, num2);
    }

    static void MostrarPrimos(int num1, int num2)
    {
        int cantidad = 0;
        int primo;

        if (num1 > num2)
        {
            int aux = num1;
            num1 = num2;
            num2 = aux;
        }

        for (int i = num1; i <= num2; i++)
        {
            primo = 1;

            if (i < 2)
            {
                primo = 0;
            }
            else
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        primo = 0;
                    }
                }
            }

            if (primo == 1)
            {
                Console.WriteLine(i);
                cantidad++;
            }
        }

        Console.WriteLine("Cantidad de numeros primos: " + cantidad);
    }
}
