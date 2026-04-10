using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("¿ Que nota sacaste en el examen ? : ");
        double nota = Convert.ToDouble(Console.ReadLine());

        if (nota >= 7)
        {
            Console.WriteLine("Estas Promocionado!!");
        }
        else if (nota >= 4 && nota <= 6)
        {
            Console.WriteLine("A Finales");
        }
        else
        {
            Console.WriteLine("A Recuperatorio");

        }
    }
}
