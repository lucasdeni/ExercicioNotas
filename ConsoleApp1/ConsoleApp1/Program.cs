using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Aluno: ");
            Aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as notas do aluno:");
            Aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double notaFinal = Aluno.NotaFinal();
            Console.WriteLine("Nota Final = " + notaFinal.ToString("F2", CultureInfo.InvariantCulture));

            double resto = Aluno.Resto();
            if(notaFinal < 60)
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltam " + resto.ToString("F2", CultureInfo.InvariantCulture) + " Pontos");

            }
            else if(notaFinal >= 60)
            {
                Console.WriteLine("Aprovado");
            }

            Console.ReadKey();
        }
    }
}
