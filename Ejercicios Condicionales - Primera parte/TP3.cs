using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ingresa un numero: ");
        double nota = Convert.ToDouble(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine("Si es par.");
        }
        else
        {
            Console.WriteLine("Es impar");
        }
    }
}
