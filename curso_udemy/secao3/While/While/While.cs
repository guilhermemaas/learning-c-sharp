using System;
using System.Globalization;

namespace While
{
    class While
    {
        static void Main(string[] args)
        {

            Console.Write("Digite um numero: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (valor >= 0.0)
            {
                double raiz = Math.Sqrt(valor);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Digite outro numero: ");
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Voce informou um numero negativo.");
        }
    }
}
