using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesoNave
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de Midiclorianos detectados en el sujeto: ");
            float midiclorianos = Convert.ToInt32(Console.ReadLine());

            if ( midiclorianos > 15000)
            {
                Console.WriteLine("Potencial Maestro Jedi detectado. Avisar al Consejo");
            }

            else
            {
                if (midiclorianos > 5000 && midiclorianos < 15000)
                {
                    Console.WriteLine("Aceptable para entrenamiento Padawan");
                }
                else
                {
                    Console.WriteLine("No posee sensibilidad a la Fuerza");
                }
                
            }
        }
    }
}
