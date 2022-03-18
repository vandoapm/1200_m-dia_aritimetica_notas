using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1200_média_aritimetica_notas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Cálculo da média aritimética das notas: N1, N2 e N3 ");
            Console.WriteLine();

            Console.Write("Nome do aluno: ");
            string a = Console.ReadLine();

            Console.Write("Nota da 1ª prova: ");
            float n1 = float.Parse(Console.ReadLine());

            Console.Write("Nota da 2ª prova: ");
            float n2 = float.Parse(Console.ReadLine());

            Console.Write("Nota da 3ª prova: ");
            float n3 = float.Parse(Console.ReadLine());

            Console.WriteLine();

            float mf = (n1 + n2 + n3) / 3.0f;

            Console.WriteLine();

            Console.Write("Aluno: ");
            Console.Write(a);
            Console.Write(" | Média final: ");
            Console.Write(mf);
            Console.ReadLine();

        }
    }
}
