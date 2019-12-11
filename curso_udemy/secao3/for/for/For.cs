using System;

namespace For
{
    class For
{
    static void Main(string[] args)
    {
            Console.Write("Favor informar quantos numeros serao somados: ");
            
            int quantidadeNumeros = int.Parse(Console.ReadLine());

            int somaTotal = 0;

            for (int i = 1; i <= quantidadeNumeros; i++)
            {
                int numeroAtual = 0;
                Console.WriteLine($"Favor informar o {i} numero: ");
                numeroAtual = int.Parse(Console.ReadLine());

                somaTotal += numeroAtual;
            }

            Console.WriteLine($"O total da soma foi: {somaTotal}.");

            //Console.WriteLine("Print nome 1:");
            //foreach (string nome in nomeCompleto) {
            //    Console.WriteLine($"Nome: {nome}.");
            //}
    }
}
}


