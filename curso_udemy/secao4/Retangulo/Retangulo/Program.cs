using System;
using System.Globalization;

namespace Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {

            Retangulo retangulo1 = new Retangulo();

            Console.WriteLine("Favor informar altura e largura do Retangulo: ");
            Console.Write("Altura: ");
            retangulo1.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Largura: ");
            retangulo1.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do Retangulo: ");
            Console.WriteLine($"{retangulo1}");
        }
    }
}
