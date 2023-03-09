using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tQuantos dia? E são quantas Semanas, Meses, Anos");
            int dia, semana, mes, ano;

            Console.WriteLine("Quantos dias você quer converter por semanas, meses, anos");
            dia = int.Parse(Console.ReadLine());

            semana = dia / 7;
            mes = dia / 30;
            ano = dia / 365;

            Console.Clear();

            Console.WriteLine("[ SEMANAS, MESES, ANO]");
            Console.WriteLine("Seus dias informadoa: {0} \nSuas semanas convertidas: {1} \nSeus meses: {2} \nSeus anos: {3}", dia, semana, mes, ano);


            


        }
    }
}
