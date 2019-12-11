using System;
using System.Globalization;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1 = new Funcionario();
            Funcionario funcionario2 = new Funcionario();

            Console.WriteLine("Favor informar o nome e salario de dois funcionarios:");

            Console.Write("Informe o nome do primeiro colaborador: ");
            funcionario1.Nome = Console.ReadLine();
            Console.Write("Informe o salario do primeiro colaborador: ");
            funcionario1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Informe o nome do segundo colaborador: ");
            funcionario2.Nome = Console.ReadLine();
            Console.Write("Informe o salario do segundo colaborador: ");
            funcionario2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string maiorSalarioInformado;
            double maiorSalario;

            if (funcionario1.Salario > funcionario2.Salario)
            {
                maiorSalarioInformado = funcionario1.Nome;
                maiorSalario = funcionario1.Salario;
            }
            else
            {
                maiorSalarioInformado = funcionario2.Nome;
                maiorSalario = funcionario2.Salario;
            }

            double mediaSalarial = (funcionario1.Salario + funcionario2.Salario) / 2.0;

            Console.Write($"A media Salarial dos dois colaboradores: {mediaSalarial.ToString("F2", CultureInfo.InvariantCulture)}.");
            Console.WriteLine($"E o colaborador com maior salario: {maiorSalarioInformado}. Valor: {maiorSalario.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
