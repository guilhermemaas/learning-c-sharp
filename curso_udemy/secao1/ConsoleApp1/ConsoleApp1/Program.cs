using System;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");

            sbyte n1 = 127; //-128.
            n1++;
            Console.WriteLine(n1);

            byte n2 = 254;
            n2++;
            Console.WriteLine(n2);
            n2++;
            Console.WriteLine(n2); //Quando ultrapassa o limite do valor da variavel oposto. => 0.

            int n3 = 1000;
            Console.WriteLine(n3);

            int n4 = 2147483647;
            long n5 = 2147483648L;
            Console.WriteLine(n4);
            Console.WriteLine(n5);

            bool completo = false;
            Console.WriteLine(completo);

            char genero = 'F';
            Console.WriteLine(genero);

            char letra = '\u0041';
            Console.WriteLine(letra);

            float n6 = 4.5f;
            Console.WriteLine(n6);

            double n7 = 4.5;
            Console.WriteLine(n7);

            string nome = "Maria";
            Console.WriteLine(nome);

            object obj1 = "Alexandre";
            object obj2 = 4.5f;
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

            /*Funcoes para valores minimos e maximos
             * int.MinValue
             * int.MaxValue
             * sbyte.MaxValue
             * long.MaxValue
             * decimal.Maxvalue
             */

            int x1 = int.MinValue;
            Console.WriteLine(x1);
            int x2 = int.MaxValue;
            Console.WriteLine(x2);

            decimal x3 = decimal.MaxValue;
            Console.WriteLine(x3);

            /*
             * Restricoes e convencoes de nomes(CamelCase):
             * Variaveis: int _5minutos, int salario, int salarioDoFuncionario;
             * Convencoes:
             * Camel Case: lastName(Parametros de metodos, variaveis dentro de metodos).
             * Pascal Case: LastName(namespaces, classe, properties e metodos).
             * Padrao _lastName(Atributos internos da classe).
             */

        }
    }
}
