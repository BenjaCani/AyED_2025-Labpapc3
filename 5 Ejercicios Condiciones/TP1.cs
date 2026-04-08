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
            Console.WriteLine("Ingrese el peso de su nave: ");
            float peso = Convert.ToInt32(Console.ReadLine());
            double descarga = peso - 5000;

            if (peso <= 5000)
            {
                Console.WriteLine("Despegue autorizado. Buen viaje, Mando");
            }
            else
            {
                Console.WriteLine("Exceso de peso. Debes descargar " + descarga + "kg para despegar");
            }
                
        }
    }
}
