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
        protected string Nome;
        protected string Cpf;
        protected double Salario;
        private static int quantidadeDeFuncionarios;
     
        public Funcionario(string Nome, string Cpf, double Salario)
        {
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Salario = Salario;
            quantidadeDeFuncionarios++;
        }

        public virtual double getBonificacao()
        {
            return Salario * 0.1;
        }
        public virtual void aumentarSalario()
        {
            this.Salario *= 1.10;
        }
        static public int getQuantidadeDeFuncionarios()
        {
            return quantidadeDeFuncionarios;
        }
        public double getSalario()
        {
            return this.Salario;
        }
    }
}
