using System;
using System.Globalization;

namespace MembrosExtaticos
{
    class Program
    {

        static void Main(string[] args)
        {

            Calculadora calc = new Calculadora();

            Console.Write("Entre com o valor de raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine($"Circunferencia: {circ.ToString("F2", CultureInfo.InvariantCulture)}.");
            Console.WriteLine($"Volume: {volume.ToString("F2", CultureInfo.InvariantCulture)}.");
            Console.WriteLine($"Pi: {Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture)}.");
        }


    }
}
