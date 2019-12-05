using System;
using System.Globalization;

namespace EntradaDados2 {
    class EntradaDados3 {
        static void Main(string[] args) {

            decimal grana = 10.404040424242m;

            Console.WriteLine(grana);
            Console.WriteLine($"{grana:N2}");
            Console.WriteLine($"{grana:N2}");

            double grana2 = 10.4542342d;
            Console.WriteLine($"{grana2:N2}");

            Console.WriteLine("---Cadastros---\n1 - Cadastro de Alunos.\n2 - Cadastro de compra de casas.");
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1) {

                Console.WriteLine("---Cadastro Aluno---");

                //Conversao de valores:

                //Nome:
                Console.WriteLine("Digite o nome do aluno:");
                string[] nomeCompleto = Console.ReadLine().Split(' ');

                //Idade:
                Console.WriteLine("Digite a idade: ");
                int idade = int.Parse(Console.ReadLine());

                //Sexo:
                Console.WriteLine("Digite o sexo: F/M:");
                char sexo = char.Parse(Console.ReadLine());

                //Nota:
                Console.WriteLine("Digite a nota da prova:");
                double nota = double.Parse(Console.ReadLine());

                //Imprime cadastro:
                string linha = "-----------";
                Console.WriteLine($"{linha}\nResumo Cadastro:\n{linha}");

                Console.WriteLine($"O nome completo do aluno possui: {nomeCompleto.Length} palavras.");

                Console.WriteLine("Print nome 1:");
                foreach (string nome in nomeCompleto) {
                    Console.WriteLine($"Nome: {nome}.");
                }

                Console.WriteLine("Print nome 2:");
                for (int i = 0; i <= nomeCompleto.Length -1; i++) {
                    Console.WriteLine($"A {i} palavra do nome: {nomeCompleto[i]}.");
                }

                Console.WriteLine($"Idade: {idade}.");

                Console.WriteLine($"Sexo: {sexo}.");

                Console.WriteLine($"Nota: {nota.ToString("F2", CultureInfo.InvariantCulture)}.");

                Console.WriteLine($"{linha}Fim Cadastro{linha}");

            } else if (opcao == 2) {

                Console.WriteLine("---Cadastro de comprador de imovel---");

                Console.WriteLine("Informe o primeiro nome do comprador:");
                string nomeComprador = Console.ReadLine();

                Console.WriteLine("Quantos quartos tem na casa:");
                int quantidadeQuartos = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe o preco do imovel:");
                float valorImovel = float.Parse(Console.ReadLine());

                Console.WriteLine("Informe o sobrenome, quantos filhos possui e quantos animais de estimacao, separado por espaco:");
                string[] dadosAdicionais = Console.ReadLine().Split(' ');

                string linha2 = "-----------";

                Console.WriteLine($"{linha2}\nResumo de Cadastro\n{linha2}");

                Console.WriteLine($"Nome do comprador: {nomeComprador}.");

                Console.WriteLine($"Quantidade de quartos: {quantidadeQuartos}");

                Console.WriteLine($"Valor do imovel: {valorImovel.ToString("F2", CultureInfo.InvariantCulture)}.");

                Console.WriteLine("Imprimindo dados adicionais: ");
                for (int i = 0; i <= dadosAdicionais.Length -1; i++) {
                    Console.WriteLine($"Dado adicional {i}: {dadosAdicionais[i]}");
                }

                Console.WriteLine($"{linha2}\nFim Cadastro\n{linha2}");
            }
        }
    }
}
