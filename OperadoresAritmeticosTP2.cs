using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresAritmeticosTP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuantos minutos estuvo estacionado? (especifique en numeros)");
            int minutos = Convert.ToInt32(Console.ReadLine());
            int hora = minutos / 60;
            int resto = minutos % 60; 

            Console.WriteLine("Estacionado: " + hora + " horas " + resto + " minutos");

            int CostoxHora = 6000 * hora;
            int CostoxMinuto = 150 * resto;
            int CostoTotal = CostoxHora + CostoxMinuto;
            Double CostoFinal = CostoTotal / 1.21;

            Console.WriteLine("Monto Final a pagar: " + CostoFinal + "$");



        
        }
    }
}
