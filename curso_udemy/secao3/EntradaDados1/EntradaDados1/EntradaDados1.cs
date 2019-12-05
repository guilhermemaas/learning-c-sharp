using System;

namespace EntradaDados1 {
    class EntradaDados1 {
        static void Main(string[] args) {

            Console.WriteLine("Saudacao: ");
            string frase = Console.ReadLine();
            Console.WriteLine($"Voce digitou: {frase}.");

            Console.WriteLine("Digite uma cor:");
            string x = Console.ReadLine();

            Console.WriteLine("Digite uma segunda cor:");
            string y = Console.ReadLine();

            Console.WriteLine("Digite uma terceira cor:");
            string z = Console.ReadLine();

            Console.WriteLine($"Cores:\nx = {x}.\ny = {y}.\nz = {z}.");

            Console.WriteLine("Digite 3 cores:");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            Console.WriteLine($"Cor 1: {a}, cor 2: {b}, cor3: {c}.");

            Console.WriteLine("Digite uma frase utilizando um espaco entre as palavras. No maximo 3 palavras.");
            string frase2 = Console.ReadLine();

            string[] lista = frase2.Split(' '); //Vetor
                                                //Split vai utilizar o valor ' ', para dividir os valores um vetor de strings. 

            string p1 = lista[0];
            string p2 = lista[1];
            string p3 = lista[2];

            Console.WriteLine($"Palavra 1: {p1}, palavra 2: {p2}, palavra 3: {p3}.");
            Console.WriteLine($"Palavra 1: {lista[0]}, palavra 2: {lista[1]}, palavra 3: {lista[2]}.");

            Console.WriteLine("Digite uma frase com duas palavras:");
            string[] lista2 = Console.ReadLine().Split(' ');
            Console.WriteLine($"Palavra 1: {lista2[0]}, palavra 2: {lista2[1]}");
            
        }
    }
}
