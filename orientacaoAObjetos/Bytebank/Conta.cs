namespace orientacaoAObjetos.Bytebank
{
    internal class Conta
    {
        private Titular titular;
        private string conta;
        private int agencia;
        private string nomeDaAngencia;
        private double saldo;
    
        public Titular getTitular()
        {
            return titular;
        }
        public void setTitular(Titular titular)
        {
            this.titular = titular;
        }
        public string getConta()
        {
            return conta;
        }
        public void setConta(string conta)
        {
            this.conta = conta;
        }
        public int getAgencia()
        {
            return agencia;
        }
        public void setAgencia(int agencia)
        {
            this.agencia = agencia;
        }
        public string getNomeDaAgencia()
        {
            return nomeDaAngencia;
        }
        public void setNomeDaAgencia(string nomeDaAgencia)
        {
            this.nomeDaAngencia = nomeDaAgencia;
        }
        public double getSaldo()
        {
            return saldo;
        }
        public bool deposita(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("DEPOSITE UM VALOR MAIOR QUE " + valor + ".");
                return false;
            }
            else
            {
                Console.WriteLine("FOI DEPOSITADO O VALOR DE $ " + valor + " NA CONTA $ " + this.conta);
                Console.WriteLine("\nSALDO ANTIGO\t: $ " + (saldo));
                this.saldo += valor;
                Console.WriteLine("SALDO ATUAL\t: $ " + (saldo));
                return true;
            }

        }

        public bool saca(double valor)
        {
            if (saldo < valor)
            {
                Console.WriteLine("SALDO INSUFICIENTE!");
                return false;
            }
            else if (valor <= 0)
            {
                Console.WriteLine("VALOR INVALIDO!");
                return false;
            }
            else
            {
                saldo = saldo - valor;
                Console.WriteLine("SALDO PÓS SAQUE\t: $ " + saldo);
                return true;
            }
        }

        public bool transfere(ContaCorrente conta, double valor)
        {
            if (saldo < valor)
            {
                Console.WriteLine("SALDO INSUFUCIENTE! " + saldo);
                return false;
            }   else if (valor <= 0)
            {
                Console.WriteLine("O VALOR $ " + valor +" é INVALIDO!");
                return false;
            }   else
            {
                saca(valor);
                conta.deposita(valor);
                Console.WriteLine("FOI TRANSFERIDO UM VALOR DE $ " + valor + " DA CONTA " + this.conta + " PARA CONTA " + conta.getConta());
                return true;
            }
            
        }
    


        public override string ToString()
        {
            return titular + "\nCONTA\t\t: " + conta + "\nAGENCIA\t\t: " + agencia + "\nNOME_AGENCIA\t: " + nomeDaAngencia;
        }
    }
}
