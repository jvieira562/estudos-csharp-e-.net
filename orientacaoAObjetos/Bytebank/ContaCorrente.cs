using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orientacaoAObjetos.Bytebank
{
    internal class ContaCorrente : Conta
    {
        const double taxa = 0.5;

        public ContaCorrente(Titular titular, string conta, int agencia, string nomeDaAgencia) :
        base(titular, conta, agencia, nomeDaAgencia)
        {
        }

        public double getTaxa()
        {
            return taxa;
        }

    }
}
