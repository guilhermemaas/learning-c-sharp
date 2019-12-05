using System;
using System.Globalization;

namespace OperadoresConversao {
    class OperadoresConversao {
        static void Main(string[] args) {

            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            int b = 20;
            b %= 3;
            Console.WriteLine(b);

            a *= 3;
            Console.WriteLine(a);

            string s = "ABC";
            Console.WriteLine(s);
            string s2 = "DEF";
            s += s2;
            Console.WriteLine(s);

            int var1 = 10;
            var1++;
            Console.WriteLine(var1);
            var1--;
            Console.WriteLine(var1);

            int b2 = var1++; //Primeiro joga o valor pra variavel b2, depois incrementa var1.
            Console.WriteLine(var1);
            Console.WriteLine(b2);

            b2 = ++var1; //Desta maneira a variavel recebe o valor incrementado da var1. Primeiro incrementa, depoisa atribui a variavel b2.
            Console.WriteLine(b2);

            //Conversao:

            float x3 = 4.5f;

            double y3 = x3;
            //Console.WriteLine(x3.ToString("1F", CultureInfo.InvariantCulture));
            Console.WriteLine(y3);
            Console.WriteLine(y3.ToString(CultureInfo.InvariantCulture));

            double a3;
            float b3;

            a3 = 5.1;
            //b3 = a3; -> Nao e possivel uma variavel float receber double, em vista de que double = 4 bytes, e float 8 bytes.

            //Casting, conversao explicita:

            b3 = (float)a3;

            Console.WriteLine(b3);

            double d1;
            int i1;

            d1 = 5.6;

            i1 = (int)d1;
            Console.WriteLine(i1);

            int i2 = 5;
            int i3 = 2;

            double resultado = (double)i2 / i3;

            Console.WriteLine(resultado);
            Console.WriteLine(resultado.ToString(CultureInfo.InvariantCulture));

        }
    }
}
