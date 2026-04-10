using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Ingrese la cantidad de droides a comprar:");
        int cantidad = Convert.ToInt32(Console.ReadLine());
        double Total = cantidad * 2000;

        if (cantidad <= 2)
        {
            Console.WriteLine("Total a pagar: " + Total + " creditos");
        }
        else
        {
            double descuento = Total * 0.20;
            double TotalFinal = Total - descuento;
            Console.WriteLine("Total original: " + Total + " creditos");
            Console.WriteLine("Ahorrado: " + descuento + " creditos");
            Console.WriteLine("El Total Final: " + TotalFinal + " creditos");
        }
    }
}