using System;

namespace OperadoresComparativosLogicos {
    class OperadoresComparativosLogicos {
        static void Main(string[] args) {

            //Operadores comparativos:
            int a = 10;
            bool c1 = a < 10;
            bool c2 = a < 20;
            bool c3 = a > 10;
            bool c4 = a > 5;

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);

            Console.WriteLine("---------------------");

            bool c5 = a <= 10;
            bool c6 = a >= 10;
            bool c7 = a == 10;
            bool c8 = a != 10;

            Console.WriteLine(c5);
            Console.WriteLine(c6);
            Console.WriteLine(c7);
            Console.WriteLine(c8);

            Console.WriteLine("---------------------");

            //Operadores logicos:
            // && = E
            // || = OU
            // ! = NAO
            // Precedencia = ! > && > ||

            bool d1 = 4 != 5; //True
            bool d2 = 2 > 3 && 4 != 5; //False
            bool d3 = 3 > 2 && 4 != 5; //True
            bool d4 = 4 > 6 || 4 != 5;
            bool d5 = a != 10;
            bool d6 = !(2 > 3) && 4 != 5;

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);

            Console.WriteLine("---------------------");

            bool d8 = d1 || c2 && d3;

            Console.WriteLine(d8);

        }
    }
}
