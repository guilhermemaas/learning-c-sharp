using System;
using System.Collections.Generic;
using System.Text;

namespace ConversorDeMoeda
{
    class ConversorDolar
    {

        public static double RetornaConversaoDolar(double quantidadeDolar, double cotacaoDolar, double iof)
        {
            return (quantidadeDolar * cotacaoDolar) + (quantidadeDolar * cotacaoDolar) * iof / 100;
        }
    }
}
