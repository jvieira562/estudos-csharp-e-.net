using orientacaoAObjetos.Bytebank;

class teste
{

    static void Main(string[] args)
    {

        ContaCorrente conta1 = new ContaCorrente();
        ContaCorrente conta2 = new ContaCorrente();

        conta1.setTitular("José Victor S. Vieira");
        conta1.setConta("10151-5");
        conta1.setAgencia(15);
        conta1.setNomeDaAgencia("Angencia Prime");
        conta1.deposita(330);

        conta2.setTitular("Vieira Santos V. José");
        conta2.setConta("51510-1");
        conta2.setAgencia(51);
        conta2.setNomeDaAgencia("Prime Agencia");
        conta2.deposita(65);
        conta2.saca(62.50);

        Console.WriteLine("SALDO APÓS TRANFERENCIA: ");
        conta1.transfere(conta2, 304.42);

        Console.WriteLine("SALDO CONTA 1\t: " + conta1.getSaldo());
        Console.WriteLine("SALDO CONTA 2\t: " + conta2.getSaldo());
        Console.WriteLine("=====================================");
        Console.WriteLine(conta1.ToString());
        Console.WriteLine(conta2.ToString());

    }

}