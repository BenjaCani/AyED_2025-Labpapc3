using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales___Segunda_Parte
{
    class Program
    {
 
        static void Main(string[] args)
        {
            Console.WriteLine("Cantidad de facturas producidas al inicio del día: ");
            int FacturaAlInicioDelDIa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cuántas docenas completas (12 unidades) se vendieron: ");
            int CantidadVendidas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Precio por docena: ");
            double PrecioXdocena= Convert.ToDouble(Console.ReadLine());

            int Sobraron = FacturaAlInicioDelDIa - CantidadVendidas;
            double PlataGanada = CantidadVendidas * PrecioXdocena;

            
            Console.WriteLine("Dinero Recaudado:" + PlataGanada);

            if (Sobraron > 6)
            {
                Console.WriteLine("Sobraron:" + Sobraron + " facturas.");
                Console.WriteLine("Alerta: Exceso de producción");      
            }

            else if (Sobraron <= 6)
            {
                Console.WriteLine("Producción eficiente");
            }
        }
    }
}
