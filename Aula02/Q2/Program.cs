using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t--Multiplicação--");
            int num1, num2, vezes;

            Console.Write("Digite um numero: ");
            num1 = int.Parse(Console.ReadLine());
          
            Console.Write("Digite um outro numero: ");
            num2 = int.Parse(Console.ReadLine());  
            
            vezes = num1 * num2 ; 

            Console.Clear();

            Console.WriteLine("\t --Resultado da Multiplicação--");
            Console.WriteLine("1° numero informado: {0} \n2° Numero informado: {1} \nResultado da multplicação dos dois numeros: {2}" ,num1, num2, vezes);




        }
    }
}
