using System;

namespace IfElse {
    class IfElse {
        static void Main(string[] args) {

            Console.WriteLine("Informe a hora do dia no formato 24h:");
            int horaAtual = int.Parse(Console.ReadLine());

            if (horaAtual < 12) {
                Console.WriteLine("Bom dia!");
            } else if (horaAtual <= 18) {
                Console.WriteLine("Boa tarde!");
            } else {
                Console.WriteLine("Boa noite!");
            }

            Console.WriteLine("--------------");
            Console.WriteLine("Informe um numero inteiro:");

            int inteiro = int.Parse(Console.ReadLine());

            if (inteiro % 2 == 0) {
                Console.WriteLine("Par");
            } else {
                Console.WriteLine("Ïmpar");
            }

            Console.WriteLine("----------------");

            //Escopo e inicializacao de variaveis:

            Console.WriteLine("Informe o valor da compra:");

            double preco = double.Parse(Console.ReadLine());
            double desconto = 0.0;

            if (preco > 100.0) {
                desconto = preco * 0.1;
            }

            Console.WriteLine($"Desconto: {desconto:N2}.");

        }
    }
}
