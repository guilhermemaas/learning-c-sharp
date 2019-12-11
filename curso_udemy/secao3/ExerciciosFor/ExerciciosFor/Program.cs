using System;

namespace ExerciciosFor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 01:

            Console.WriteLine("Informe um numero inteiro para exibir os impares de 1 ate o mesmo:");

            int valorInformadoImpar = int.Parse(Console.ReadLine());

            for (int i = 1; i <= valorInformadoImpar; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine($"O valor e um impar, segue: {i}.");
                } else
                {
                    Console.WriteLine($"O valor e par, segue {i}.");
                }
            }

            //Exercicio 02:


        }
    }
}
