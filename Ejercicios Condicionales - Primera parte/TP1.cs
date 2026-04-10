using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Escribe tu Nombre : ");
        string Nombre = Console.ReadLine();
        Console.WriteLine("Indique la velocidad de su vehiculo: ");
        int edad = Convert.ToInt32(Console.ReadLine());
        if (edad >= 18)
        {
            Console.WriteLine("Bienvenido al club " + Nombre + ".");
        }
        else
        {
            Console.WriteLine("Lo siento, eres muy polluelo.");
        }

    }
}
