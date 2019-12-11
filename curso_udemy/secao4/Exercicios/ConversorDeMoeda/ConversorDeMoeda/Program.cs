using System;
using System.Globalization;

namespace ConversorDeMoeda
{
    class Program
    {

        static void RetornarOpcoesMoedas()
        {
            Console.WriteLine("Favor informar uma das moedas abaixo:\n1 - Dolar(- IOF = 6%).");
        }
        static void Main(string[] args)
        {

            Console.WriteLine("---===Conversor de Moeda===---");
            RetornarOpcoesMoedas();

            Boolean continuar = true;

            while(continuar == true)
            {
                Console.Write("Qual a cotacao do dolar? ");
                double cotacaoAtualDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Quantos dolares voce vai comprar?");
                double quantidadeDolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double dolarConvertidoReal = ConversorDolar.RetornaConversaoDolar(quantidadeDolares, cotacaoAtualDolar, 6.00);

                Console.WriteLine($"Valor em dolar: {quantidadeDolares.ToString("F2", CultureInfo.InvariantCulture)}.\n" +
                    $"Quantidade de Dolares{quantidadeDolares.ToString("F2", CultureInfo.InvariantCulture)}.\n" +
                    $"Valor a ser pago em Reais: {dolarConvertidoReal.ToString("F2", CultureInfo.InvariantCulture)}.");

                Console.WriteLine("Desaja realizar mais uma conversao? S/N"); 
                string continuarS = Console.ReadLine();

                if (continuarS == "N" || continuarS == "n")
                {
                    Console.WriteLine("Programa de conversao finalizado.");
                    continuar = false;
                }
                else
                {
                    continuar = true;
                }
            }
        }
    }
}
