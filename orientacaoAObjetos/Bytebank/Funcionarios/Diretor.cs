using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orientacaoAObjetos.Bytebank.Funcionarios
{
    public class Diretor : Funcionario
    {
        public Diretor(string nome, string cpf, double salario) : base(nome, cpf, salario)
        {

        }
        public override double getBonificacao()
        {
            return this.Salario + base.getBonificacao();
        }
        public override void aumentarSalario()
        {
            this.Salario *= 1.15;
        }
    }
}
