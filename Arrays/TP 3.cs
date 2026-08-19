using System;

class Program
{
    static void Main()
    {
        /*Un curso tiene 20 clases en el cuatrimestre. Para un alumno, se registra su asistencia clase por clase como
        presente o ausente. Al finalizar la carga, el programa debe informar el total de inasistencias y si el alumno queda
        “Libre por inasistencias” (más de 6 ausencias) o “Regular”.*/

        int[] Curso = new int [20];
        int Presente = 0;
        int Ausentes = 0;
        string estado = "";
  

        for (int n=0; n < Curso.Length; n++)
        {
            Console.WriteLine($"Asistencia Clase {n+1} ---- P o A");
            estado = Console.ReadLine();

            if (estado == "P")
            {
                Presente++;
            }
            else
                Ausentes++;
             
        }
        
        if (Ausentes > 6)
        {
            Console.WriteLine($"Queda Libre por inasistenciasa (Faltas {Ausentes})");
        }
        else
            Console.WriteLine("Regular");

    }
}
