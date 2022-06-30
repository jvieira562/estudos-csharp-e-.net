using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orientacaoAObjetos.Bytebank
{

    internal class Titular
    {
        private string titular;
        private string cpf;
        private string profissao;

        public Titular(string nome, string cpf, string profissao)
        {
            titular = nome;
            this.cpf = cpf;
            this.profissao = profissao;
        }

        public string getNome()
        {
            return titular;
        }
        public void setNome(string nome)
        {
            titular = nome;
        }
        public string getCpf()
        {
            return cpf;
        }
        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }
        public string getProfissao()
        {
            return profissao;
        }
        public void setProfissao()
        {
            profissao = profissao;
        }

        public override string ToString()
        {
            return "TITULAR\t\t: " + titular + "\nCPF\t\t: " + cpf + "\nPROFISSÃO\t: " + profissao;
        }

    }
}
