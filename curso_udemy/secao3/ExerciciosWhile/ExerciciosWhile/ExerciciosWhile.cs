using System;

namespace ExerciciosWhile
{
    class ExerciciosWhile
    {
        static void Main(string[] args)
        {
            //Exercicio1:

            string senhaCorreta = "2002";
            String senhaInformada = "";

            while (senhaInformada != senhaCorreta)
            {
                Console.WriteLine("Informe a senha correta para prosseguir: ");
                senhaInformada = Console.ReadLine();
                if (senhaInformada != senhaCorreta)
                {
                    Console.WriteLine("Senha incorreta, tente novamente.");
                }
            }

            Console.WriteLine($"Senha correta informada: {senhaCorreta}");

            //Exercicio2:

            Console.WriteLine("Escolha a opcao abaixo:\n1 - Alcool\n2 - Gasolina\n3 - Diesel\n4 - Fim");

            int opcaoInformada = 0;
            int totalAlcool = 0;
            int totalGasolina = 0;
            int totalDiesel = 0;

            while (opcaoInformada != 4)
            {
                Console.WriteLine("Informe o tipo de combustivel, ou 4 para sair:");
                opcaoInformada = int.Parse(Console.ReadLine());

                if (opcaoInformada == 1)
                {
                    totalAlcool += 1;
                } else if (opcaoInformada == 2)
                {
                    totalGasolina += 1;
                } else if (opcaoInformada == 3)
                {
                    totalDiesel += 1;
                } else if (opcaoInformada > 4 || opcaoInformada < 0)
                {
                    Console.WriteLine("Informe uma opcao valida, 4 para sair.\n1 - Alcool\n2 - Gasolina\n3 - Diesel");
                }
            }

            Console.WriteLine($"MUITO OBRIGADO!\nTotalizadores:\nAlcool: {totalAlcool}.\nGasolina: {totalGasolina}.\nDiesel{totalDiesel}.");
        }
    }
}
