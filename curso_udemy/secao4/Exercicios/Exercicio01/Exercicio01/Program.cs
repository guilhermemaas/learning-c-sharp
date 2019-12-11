using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {

            Pessoa pessoa1, pessoa2;

            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();

            Console.WriteLine("Informe os dados de duas pessoas para verificar qual a mais velha.");

            Console.Write("Dados Pessoa 1:\nNome: ");
            pessoa1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa1.Idade = int.Parse(Console.ReadLine());

            Console.Write("Dados Pessoa 2:\nNome: ");
            pessoa2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa2.Idade = int.Parse(Console.ReadLine());

            string pessoaMaiorIdade = "";

            if (pessoa1.Idade > pessoa2.Idade)
            {
                pessoaMaiorIdade = pessoa1.Nome;
            }
            else
            {
                pessoaMaiorIdade = pessoa2.Nome;
            }

            Console.WriteLine($"A pessoa com maior idade: {pessoaMaiorIdade}.");
        }
    }
}
