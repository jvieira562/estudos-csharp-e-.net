using orientacaoAObjetos.Bytebank;

class teste
{

    static void Main(string[] args)
    {

        Titular victor = new Titular("José Victor", "051.064.564-90", "Tester");
        Titular vieira = new Titular("Vieira Santos", "561.562.266-10", "Programer");

        ContaCorrente cc = new ContaCorrente(victor, "10053-5", 43, "Prime Agencia");
        ContaCorrente cc2 = new ContaCorrente(vieira, "4469-8", 56, "Primeira Money");

        cc.deposita(50.70);
        cc2.deposita(32);
        

        Console.WriteLine(cc.ToString());
        Console.WriteLine("=================================");
        Console.WriteLine(cc2.ToString());
        Console.WriteLine("=================================");
        Console.WriteLine("CC GETSALDO\t: $ " + cc.getSaldo());
        Console.WriteLine("CC2 GETSALDO\t: $ " + cc2.getSaldo());



    }

}