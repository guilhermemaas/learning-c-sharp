using System;

namespace FuncoesSintaxe
{
    class DebugMetodos
    {
        static void Main(string[] args)
        {

            //Debugging:
            // F9 - Marca a linha para debug a partir da mesma
            // F10 - Avanca
            // shift + f5 interrompe o debug.
            // f11 entra em uma funcao/metodo durante o debug.
            // shift + f11 sai do debug da funcao/metodo.

            Console.WriteLine("Digite tres numeros: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3);

            Console.WriteLine($"Maior numero: {resultado}.");
        }


        static int Maior(int a, int b, int c)
        {
            int m;

            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m;
        }
    }
}
