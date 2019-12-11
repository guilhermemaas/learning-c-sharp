using System;

namespace TriangulosOO
{
    class Triangulo
    {

        public double LadoA;
        public double LadoB;
        public double LadoC;

        public double Area()
        {
            double p = (LadoA + LadoB + LadoC) / 2.0;
            double raiz = Math.Sqrt(p * (p - LadoA) * (p - LadoB) * (p - LadoC));
            return raiz;
        }

    }
}
