using System;

class Programa
{
    static void Main()
    {
        double temperatura;
        double suma = 0;
        int contadorBajoCero = 0;

        for (int i = 1; i <= 7; i++)
        {
            Console.Write("Ingrese la temperatura del día " + i + ":");
            temperatura = double.Parse(Console.ReadLine());
            suma = suma + temperatura;

            if (temperatura < 0)
            {
                contadorBajoCero++;
            }
        }

        Console.WriteLine("Suma de temperaturas: " + suma);
        Console.WriteLine("Cantidad de días -0°C: " + contadorBajoCero);
    }
}