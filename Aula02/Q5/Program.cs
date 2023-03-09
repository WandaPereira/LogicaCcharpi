using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t [Consumo de Combustivel]");
            double km, litros, cons;

            Console.WriteLine("Informe quantidade de Litros no seu carro: ");
            litros = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe quantidades de Quilometros rodados em seu carro: ");
            km = double.Parse(Console.ReadLine());

            cons = km/litros;

            Console.Clear();
            Console.WriteLine("\t CONSUMO DE COMBUSTIVEL");
            Console.WriteLine($"Seu carro consumiu um total de : {cons} ");



        }
    }
}
