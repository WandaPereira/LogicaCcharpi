using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1


{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t Dados de usuario");
            string nome, endereco, telefone;

            Console.Write("informe seu nome: ");
            nome = Console.ReadLine();

            Console.Write("informe endereço: ");
            endereco= Console.ReadLine();

            Console.Write("informe seu numero: ");
            telefone= Console.ReadLine();

            Console.Clear();

            Console.WriteLine("\t\tDados de usuario\n");
            Console.WriteLine("Nome: {0} \nEndereço: {1} \nTelefone: {2}", nome, endereco, telefone);

        }
    }
}
