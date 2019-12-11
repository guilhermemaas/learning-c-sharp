using System;
using System.Globalization;

namespace ControleEstoque
{
    class Program
    {
        static void Main(string[] args)
        {

            //Objetc possui os seguintes metodos:
            //GetType - Retorna o objeto.
            //Equals - Compara se o objeto e igual a outro.
            //GetHashCode - Retorna um codigo de hash do objeto.
            //ToString - Converte o objeto para string.

            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto a ser cadastrado:");

            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preco: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade em estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Dados do produto: " + p + ".");

            Console.WriteLine();

            Console.Write("Digite o numero de produtos a serem adicionados ao estoque: ");
            int quantidadeParaAdicionar = int.Parse(Console.ReadLine());
            p.AdicionarProtudos(quantidadeParaAdicionar);

            Console.WriteLine();

            Console.WriteLine($"Dados atualizados: {p}.");

            Console.WriteLine();

            Console.Write("Digie um numero de produtos a serem removidos do estoque: ");
            int quantidadeParaRemover = int.Parse(Console.ReadLine());
            p.RemoverProdutos(quantidadeParaRemover);

            Console.WriteLine();

            Console.WriteLine($"Dados atualizados: {p}.");

        }
    }
}
