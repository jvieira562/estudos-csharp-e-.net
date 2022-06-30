using orientacaoAObjetos.Bytebank.Utilitario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orientacaoAObjetos.Bytebank.Funcionarios
{
    public class Funcionario
    {
        private string Nome;
        private string Cpf;
        protected double Salario;
     
        public Funcionario(string Nome, string Cpf, double Salario)
        {
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Salario = Salario;
        }

        public virtual double getBonificacao()
        {
            return Salario * 0.1;
        }
    }
}
