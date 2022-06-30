using orientacaoAObjetos.Bytebank.Funcionarios;
using orientacaoAObjetos.Bytebank.Utilitario;

class teste
{

    static void Main(string[] args)
    {

        Funcionario victor = new Funcionario("Victor Vieira", "043.435.435-98", 2000);
        Funcionario vieira = new Diretor("Vieira Victor", "343.754.543-87", 3000);
        GerenciadorDeBonificacoes gerenciador = new GerenciadorDeBonificacoes();
        Console.WriteLine("VICTOR: " + victor.getBonificacao());
        Console.WriteLine("VIEIRA: " + vieira.getBonificacao());
        gerenciador.registrar(victor);
        gerenciador.registrar(vieira);
        Console.WriteLine("TOTAL DE BONIFICACOES: " + gerenciador.getBonificacao());



    }

}