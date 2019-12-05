using System;

namespace ExerciciosPropostos1 {
    class ExerciciosPropostos1 {
        static void Main(string[] args) {

            //Exercicio 01:
            Console.WriteLine("Informe dois numeros inteiros para soma: ");

            Console.WriteLine("Numero 1:");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Numero 2:");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"A soma entre {numero1} e {numero2}: {numero1 + numero2}.");

            //Exercicio 02:
            Console.WriteLine("Informe o raio de um circulo para calcular a area deste: ");

            double raio = double.Parse(Console.ReadLine());

            raio = raio * raio;

            double v1 = 3.14159;

            double area = v1 * raio;

            Console.WriteLine($"Area: {area:N4}.");

            //Exercicio 03:
            Console.WriteLine("Informe quatro numeros: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            Console.WriteLine($"Diferencao: {(a * b) - (c * d)}.");

            //Exercucio 04:
            Console.WriteLine("Informe o codigo do funcionario:");
            int codigoFuncionario = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor ganho por hora:");
            double valorHora = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de horas trabalhadas:");
            int quantidadeHorasMes = int.Parse(Console.ReadLine());

            Console.WriteLine($"O salario do colaborador {codigoFuncionario}: R${(valorHora * quantidadeHorasMes):N2}.");

            //Exercicio 05:
            Console.WriteLine("---Cadastro de compra de Pecas---");

            Console.WriteLine("Informe o codigo da Peca 1:");
            int codigoPeca1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o numero de pecas 1:");
            int quantidadePeca1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o preco da peca 1:");
            double valorPeca1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o codigo da Peca 2:");
            int codigoPeca2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o numero de pecas 2:");
            int quantidadePeca2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o preco da peca 2:");
            double valorPeca2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Pecas selecionadas: 1 - {codigoPeca1}, quantidade: {quantidadePeca1}, valor unidade: {valorPeca1}.");
            Console.WriteLine($"Pecas selecionadas: 2 - {codigoPeca2}, quantidade: {quantidadePeca2}, valor unidade: {valorPeca2}.");
            double totalPagamento = (quantidadePeca1 * valorPeca1) + (quantidadePeca2 * valorPeca2);
            Console.WriteLine($"Valor total a pagar: R${totalPagamento:N2}.");

        }
    }
}
