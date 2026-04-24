using System;

class Program
{
    static void Main()
    {
        int num1, num2, num3;

        Console.Write("Ingrese el primer número: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese el segundo número: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese el tercer número: ");
        num3 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2)
        {
            if (num1 > num3)
            {
                Console.WriteLine("El mayor es: " + num1);
            }
            else
            {
                Console.WriteLine("El mayor es: " + num3);
            }
        }
        else
        {
            if (num2 > num3)
            {
                Console.WriteLine("El mayor es: " + num2);
            }
            else
            {
                Console.WriteLine("El mayor es: " + num3);
            }
        }
    }
}
