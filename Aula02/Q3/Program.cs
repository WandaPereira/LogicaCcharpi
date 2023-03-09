using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t _Media de idade de alunos_");
            int idade1, idade2, idade3, idade4, idade5, media;

            Console.WriteLine("Aluno 1 informe sua idade");
            idade1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Aluno 2 informe sua idade");
            idade2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Aluno 3 informe sua idade");
            idade3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Aluno 4 informe sua idade");
            idade4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Aluno 5 informe sua idade");
            idade5 = int.Parse(Console.ReadLine());


            media = (idade1 + idade2 + idade3 + idade4 + idade5) / 5;

            Console.Clear();

            Console.WriteLine("\t __Idade media da Turma__");
            Console.WriteLine("Resultado Da media de idade da sala: {0} ", media);
            

        }
    }
}
