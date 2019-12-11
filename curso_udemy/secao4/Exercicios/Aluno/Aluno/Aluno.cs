using System;
using System.Collections.Generic;
using System.Text;

namespace Aluno
{
    class Aluno
    {

        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFinal()
        {
            return (Nota1 + Nota2 + Nota3) / 3.0;
        }

        public Boolean ValidarNotas()
        {
             if (NotaFinal() >= 70.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double PontosFaltantes()
        {
            return 70.0 - NotaFinal();
        }
    }
}
