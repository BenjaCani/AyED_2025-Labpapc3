using System;

class Programa
{
    static void Main()
    {
        double total = 0;
        int contadorMayores500 = 0;

        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Ingrese el gasto " + i + ":");
            double gasto = double.Parse(Console.ReadLine());
            total = total + gasto;
            Console.WriteLine("Acumulado: " + total);

            if (gasto > 500)
            {
                contadorMayores500 = contadorMayores500 + 1;
            }
        }

        Console.WriteLine("Gasto total: " + total + "$");
        Console.WriteLine("Cantidad de gastos mayores a $500: " + contadorMayores500);
    }
}