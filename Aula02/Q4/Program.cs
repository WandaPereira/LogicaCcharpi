using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t[Cauculo de volume da Caixa]");
            int altura, largura, comprimento, volume;

            Console.WriteLine("Informe a Altura da sua caixa: ");
            altura = int.Parse(Console.ReadLine());

            Console.WriteLine("informe a Largura da sua caixa: ");
            largura = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o Comprimento da sua caixa: ");
            comprimento = int.Parse(Console.ReadLine());

            volume = altura * largura * comprimento;

            Console.Clear();

            Console.WriteLine("\t [Volume]");
            Console.WriteLine($"O volume da sua Caixa é: {volume}");

        }
    }
}
