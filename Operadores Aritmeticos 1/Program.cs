using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingrese el Primer Numero: ");
            float valor1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el Segundo Numero: ");
            float valor2 = Convert.ToInt32(Console.ReadLine());

            float suma = valor1 + valor2;
            float resta = valor1 - valor2;
            float multiplicacion = valor1 * valor2;
            float division = (valor1) / (valor2);

            Console.WriteLine("Suma:" + valor1+"+"+valor2 + "= " + suma);
            Console.WriteLine("Resta:" + valor1+"-"+valor2 + "= " + resta);
            Console.WriteLine("Multiplicacion:" + valor1 + "x" + valor2 + "= " + multiplicacion);
            Console.WriteLine("Division:" + valor1+"/"+valor2 + "= " + division);







        }
    }
}
