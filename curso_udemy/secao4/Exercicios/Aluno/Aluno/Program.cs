using System;
using System.Globalization;

namespace Aluno
{
    class Program
    {
        static void Main(string[] args)
        {

            Aluno aluno1 = new Aluno();

            Console.WriteLine("---===Cadastro de Notas de Alunos===---");

            Console.Write("Informe o nome do Aluno: ");
            aluno1.Nome = Console.ReadLine();

            Console.Write("Informe a nota do primeiro trimestre: ");
            aluno1.Nota1 = double.Parse(Console.ReadLine());

            Console.Write("Informe a nota do segundo trimestre: ");
            aluno1.Nota2 = double.Parse(Console.ReadLine());

            Console.Write("Informe a nota do terceiro trimestre: ");
            aluno1.Nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine($"NOTA FINAL: {aluno1.NotaFinal().ToString("F2", CultureInfo.InvariantCulture)}.");
            if(aluno1.ValidarNotas() == true)
            {
                Console.WriteLine("SIT.: APROVADO");
            }
            else
            {
                Console.WriteLine("SIT.: REPROVADO.");
            }

            if(aluno1.NotaFinal() >= 70.00)
            {
                Console.WriteLine("Passou direto!");
            }
            else
            {
                Console.WriteLine($"Faltaram {aluno1.PontosFaltantes().ToString("F2", CultureInfo.InvariantCulture)}.");
            }

            Console.WriteLine("Fim Cadastro.");
        }
    }
}
