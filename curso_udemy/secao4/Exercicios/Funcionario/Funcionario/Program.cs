using System;
using System.Globalization;

namespace Funcionario
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionario funcionario1 = new Funcionario();

            Console.WriteLine("---===Cadastro de funcionarios===---");
            Console.WriteLine();

            Console.Write("Informe o nome do colaborador: ");
            funcionario1.Nome = Console.ReadLine();

            Console.Write("Informe o salario do colaborador: ");
            funcionario1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Informe o valor total de imposto mensal: ");
            funcionario1.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine($"Dados do colaborador: {funcionario1}.");

            Console.Write("Qual o percentual de aumento que deseja aplicar? ");
            double percentualAumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario1.AumentarSalario(percentualAumento);

            Console.WriteLine();

            Console.WriteLine($"Dados do colaborador apos aumento: {funcionario1}.");
        }
    }
}
