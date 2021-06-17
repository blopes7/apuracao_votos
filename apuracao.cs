using System;
using System.Collections.Generic;
using System.Text;

namespace Apuracao_votos
{
    class apuracao
    {
        public double totalEleitor, valido, branco, nulo;
        public apuracao()
        {
        }

        public apuracao(double totalEleitor, double valido, double branco, double nulo)
        {
            this.totalEleitor = totalEleitor;
            this.valido = valido;
            this.branco = branco;
            this.nulo = nulo;
        }

    }
}
