using System;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int suma = 0;

            Console.Write("Ingrese un numero: ");
            num = int.Parse(Console.ReadLine());

            NumerosPerfectos(num, suma);
        }

        static void NumerosPerfectos(int num, int suma)
        {
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    suma += i;
                }
            }

            if (suma == num && num > 0)
            {
                Console.WriteLine("Es un numero perfecto");
            }
            else
            {
                Console.WriteLine("No es un numero perfecto");
            }
        }
    }
}