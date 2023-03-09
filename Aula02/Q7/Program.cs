using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t --Consorcio--");
            int pres, pago, valor, total, devendo;

            Console.WriteLine("Total das suas prestações: ");
            pres = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade das prestações pagas");
            pago = int.Parse(Console.ReadLine());  

            Console.WriteLine("Valor prestação: ");
            valor = int.Parse(Console.ReadLine());

            pago = pres * valor;

            devendo = pago - valor
            Console.Clear();
            Console.WriteLine("\tDados do seu consorcio");
            Console.WriteLine("Valor total que ja foi pago {0} \nQuantidade a ser paga: {1}", pago, devendo);

            
        }
    }
}
