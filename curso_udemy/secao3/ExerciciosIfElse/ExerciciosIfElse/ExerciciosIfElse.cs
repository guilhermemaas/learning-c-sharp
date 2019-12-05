using System;

namespace ExerciciosIfElse {
    class ExerciciosIfElse {
        static void Main(string[] args) {

            //Exercicio 1:

            Console.WriteLine("Informe um numero inteiro para verificar se e negativo ou nao:");

            int inteiro = int.Parse(Console.ReadLine());

            if (inteiro < 0) {
                Console.WriteLine("Numero informado negativo.");
            } else {
                Console.WriteLine("Numero informado positivo.");
            }

            //Exercicio 2:

            Console.WriteLine("Informe um numero para verificar se e par ou impar:");

            int inteiro2 = int.Parse(Console.ReadLine());

            if (inteiro2 % 2 == 0) {

                Console.WriteLine("O numero inteiro e par.");

            } else {

                Console.WriteLine("O numero inteiro e impar.");

            }

            //Exercicio 3:

            Console.WriteLine("Informe dois numeros, A e B, para verificar se sao multiplos.");

            Console.WriteLine("Informe o valor de A:");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de B:");
            int B = int.Parse(Console.ReadLine());

            if (A % B == 0 || B % A == 0) {

                Console.WriteLine("E divisivel.");

            } else {

                Console.WriteLine("Nao e divisivel");

            }

            //Exercicio 4:

            Console.WriteLine("Informe a hora inicial do jogo: ");
            int horaInicial = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a hora final do jogo:");
            int horaFinal = int.Parse(Console.ReadLine());

            int tempoTotalJogo = 0;

            if (horaInicial > horaFinal) {

                horaInicial = 24 - horaInicial;

                tempoTotalJogo = horaFinal + horaInicial;

            } else if (horaInicial < horaFinal) {

                tempoTotalJogo = horaFinal - horaInicial;

            } else if (horaInicial == 0 || horaFinal == 0) {

                tempoTotalJogo = 24;

            }

            Console.WriteLine($"Tempo total do jogo(em horas): {tempoTotalJogo}.");

            // Exercicio 5:

            Console.WriteLine("Informe o codigo do produto: ");
            int codigoProduto = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade desse produto: ");
            int quantidadeProduto = int.Parse(Console.ReadLine());

            double valorTotalConta = 0.0;

            if (codigoProduto == 1) {

                valorTotalConta = quantidadeProduto * 4.00;

            } else if (codigoProduto == 2) {

                valorTotalConta = quantidadeProduto * 4.50;

            } else if (codigoProduto == 3) {

                valorTotalConta = quantidadeProduto * 5.00;

            } else if (codigoProduto == 4) {

                valorTotalConta = quantidadeProduto * 2.00;

            } else if (codigoProduto == 5) {

                valorTotalConta = quantidadeProduto * 1.50;

            } else {

                Console.WriteLine("Valor informado invalido.");

            }

            Console.WriteLine($"O total da conta: R${valorTotalConta:N2}");

            //Exercicio 06:

            //string[] numerosLista = Console.ReadLine().Split('.');

            Console.WriteLine("Ïnforme um valor para verificar se enquadra nos seguintes conjuntos:\n1-[0-25],2-[25-50],3-[50-75],4-[75-100]:");

            double numeroInformado = double.Parse(Console.ReadLine());
            int grupoNumeros = 0;

            if (numeroInformado >= 0 && numeroInformado < 25) {

                grupoNumeros = 1;

            } else if (numeroInformado >= 25 && numeroInformado < 50) {

                grupoNumeros = 2;

            } else if (numeroInformado >= 50 && numeroInformado < 75) {

                grupoNumeros = 3;

            } else if (numeroInformado >= 7 && numeroInformado <= 100) {

                grupoNumeros = 4;

            }

            Console.WriteLine($"O numero informado: {numeroInformado} pertence ao grupo: {grupoNumeros}.");

            // Exercicio 07:

            Console.WriteLine("Informe o salario para calcular o valor de imposto a ser pago.");

            double salario = double.Parse(Console.ReadLine());

            double valorImposto = 0;

            if (salario == 0)
            {

                Console.WriteLine("Salario igual a 0.");

            }
            else if (salario > 0 && salario <= 2000)
            {

                valorImposto = 0;

                Console.WriteLine("Salario ate R$2.000,00 fica isento de pagamento de impostos.");

            }
            else if (salario >= 2000.01 && salario <= 3000.01)
            {

                valorImposto = (salario * 8) / 100;

            }
            else if (salario >= 3000.01 && salario <= 4500)
            {

                valorImposto = (salario * 18) / 100;

            }
            else if (salario > 4500)
            {
                valorImposto = (salario * 28) / 100;
            }

            Console.WriteLine($"Salario: {salario}. O total de imposto a ser pago: {valorImposto:N2}");

        }
    }
}
