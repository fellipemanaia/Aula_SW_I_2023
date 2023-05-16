namespace exercicio03;
class Program
{
    static void Main(string[] args)
    {
        Contrato c = new Contrato();
        ContratoPessoaFisica cf = new ContratoPessoaFisica();
        ContratoPessoaJuridica cj = new ContratoPessoaJuridica();

        cf.Tipo = "Pessoa Física";
        cf.Idade = 50;
        cf.Cpf = 12345678910;
        cj.Tipo = "Pessoa Jurídica";
        cj.Cnpj = 19876543210;
        cj.Inscricao = 13579246810;
        cj.Prazo = 10;
        cf.Prazo = 10;
       

        Console.WriteLine("Tipo de contrato: " + cf.Tipo + "//Idade: " + cf.Idade + "//CPF: " +cf.Cpf + "//Valor do contrato: " + c.CalcularPrestacao() + "//Prazo de pagamento: "+ cf.Prazo + "//Valor das prestações: " + cf.CalcularPrestacao());
        Console.WriteLine("Tipo de contrato: " + cj.Tipo + "//CNPJ: " + cj.Cnpj + "//Inscrição estadual: " +cj.Inscricao + "//Valor do contrato: " + c.CalcularPrestacao() + "//Prazo de pagamento: " + cj.Prazo + "//Valor das prestações: " + cj.CalcularPrestacao());
        
    }
} 

