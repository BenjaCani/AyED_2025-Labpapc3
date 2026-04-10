using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Indique la velocidad de su vehiculo: ");
        int velocidad = Convert.ToInt32(Console.ReadLine());
        if (velocidad > 120)
        {
            Console.WriteLine("Multa en camino, exceso de velocidad);
        }
        else
        {
            Console.WriteLine("Conduccion segura");
        }

    }
}
