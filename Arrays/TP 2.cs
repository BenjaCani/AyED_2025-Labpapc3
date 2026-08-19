using System;

class Program
{
    static void Main()
    {
        /* El programa debe permitir cargar las 10 notas (valores de 1 a 10) y
        luego mostrar cuántos alumnos aprobaron (nota mayor o igual a 6), cuántos desaprobaron, y el promedio
        general del curso.*/

        int [] Curso = new int [10];
        int aprobados = 0;
        int desaprobados = 0;
        int suma = 0;
        int nota;

        for (int n=0; n < Curso.Length; n++)
        {
            Console.WriteLine($"Notas del Alumno {n+1}");
            nota = Convert.ToInt32(Console.ReadLine());

            if (nota >= 1 && nota <= 10)
            {
                if (nota >= 6 || nota <= 10)
                {
                    aprobados++;
                    suma+=nota;
                    

                }

                else if (nota < 6 || nota >= 1)
                {
                    desaprobados++;
                    suma+= nota;
                }
            }
            else
                Console.WriteLine("INVALIDO");
        }
        double promedio = suma / 10;

        Console.WriteLine($"Alumnos A: {aprobados}");
        Console.WriteLine($"Alumnos F: {desaprobados}");
        Console.WriteLine($"Promedio: {promedio}");
    }
}
