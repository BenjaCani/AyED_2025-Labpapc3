using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Ingrese el monto de la comprar:");
        int monto = Convert.ToInt32(Console.ReadLine());

        if (monto >= 5000)
        {
            double descuento = monto * 0.15;
            double TotalFinal = Total - descuento;
            Console.WriteLine("Total con descuento: " + TotalFinal + " creditos");
        }
        else
        {
            Console.WriteLine("Total original: " + Total + " creditos");
        }
    }
}