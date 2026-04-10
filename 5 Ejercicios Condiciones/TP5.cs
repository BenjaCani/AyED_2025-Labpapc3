using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("UN TES DE PERSONALIDAD BASADO EN ACCIONES");
        Console.WriteLine("- Encuentras un cristal Kyber perdido -");
        Console.WriteLine("- ¿Que haces? -");

        Console.WriteLine("Opción 1: Lo devuelves al templo.");
        Console.WriteLine("Opción 2: Lo vendes por créditos.");
        Console.WriteLine("Opcion 3: Lo usas para construir un arma roja.");

        Console.WriteLine("(Escribe el numero de la opcion que eliges)");
        int respuesta = Convert.ToInt32(Console.ReadLine());

        if (respuesta == 1)
        {
            Console.WriteLine("El camino del Jedi sigue.");
        }
        else if (respuesta == 2)
        {
            Console.WriteLine("Un cazarrecompensas eres.");
        }
        else
        {
            Console.WriteLine("El Lado Oscuro se apodera de ti.");
        }

    }
}
