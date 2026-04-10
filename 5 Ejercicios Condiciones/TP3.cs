using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese la distancia (años luz): ");
        double distancia = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingresa la cantidad combustible actual: ");
        double combustible = Convert.ToDouble(Console.ReadLine());
        double combustibleNecesario = distancia * 12;

        if (combustible >= combustibleNecesario)
        {
            Console.WriteLine("Cálculos precisos. Saltando al hiperespacio");
        }
        else
        {
            double faltante = combustibleNecesario - combustible;
            Console.WriteLine("Peligro: Combustible insuficiente. Faltan " + faltante + " litros");
        }
    }
}