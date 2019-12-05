using System;
using System.Globalization;

namespace SaidaDeDados {
    class SaidaDeDados {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");

            Console.WriteLine("teste");

            string var1 = "texto01";
            string var2 = "texto02";
            Console.Write(var1);
            Console.WriteLine(var2); //Write, diferente do WriteLine, imprime sem incluir quebra de linha ao final.

            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.WriteLine("------------");
            Console.WriteLine("\n");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2")); //F4 quatro casas, delimita a quantidade de casas, arredondado.
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture)); //Ignora formatacao de Pais.

            Console.WriteLine("------------");
            Console.WriteLine("\n");

            //Placeholders
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais.", nome, idade, saldo);

            //Interpolacao, a partir da v6 do C#.
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais.");

            //Concatenacao, mais antiga
            Console.WriteLine(nome + " tem " + idade + "anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");

            //Exercicio
            Console.WriteLine("------");

            string produto1 = "Computador";
            string produto2 = "Monitor";

            byte idade2 = 30;
            int codigo = 5290;
            char genero2 = 'M';

            double preco1 = 2100.0;
            double preco2 = 1000.0;
            double polegadas = 24.545;

            Console.WriteLine($"Produtos: \n{produto1}, cujo preco: R${preco1}.\n{produto2}, cujo preco: R${preco2}.\n\nRegistro: {idade2}, codigo {codigo} e genero: {genero2}.\nPolegados do monitor: {polegadas.ToString("F2", CultureInfo.InvariantCulture)}.");

        }
    }
}
