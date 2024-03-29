﻿using System.Globalization;

namespace Funcionario
{
    class Funcionario
    {

        public string Nome;
        public double Salario;
        public double Imposto;

        public double SalarioLiquido()
        {
            return Salario - Imposto;
        }

        public void AumentarSalario(double percentualAumento)
        {
            Salario += (Salario * percentualAumento) / 100.00;
        }

        public override string ToString()
        {
            return $"{Nome}, R${SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
