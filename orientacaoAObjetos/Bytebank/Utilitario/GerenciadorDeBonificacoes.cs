using orientacaoAObjetos.Bytebank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orientacaoAObjetos.Bytebank.Utilitario
{
    public class GerenciadorDeBonificacoes
    {
        private double totalBonificacao;

        public double getBonificacao()
        {
            return this.totalBonificacao;
        }
        public void registrar(Funcionario funcionario)
        {
            this.totalBonificacao += funcionario.getBonificacao();
        }

    }
}
