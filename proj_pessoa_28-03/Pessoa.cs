namespace proj_pessoa_28_03;
class Pessoa
{
    public Pessoa(){
        this.Nome = "fulano";
        this.Sobrenome = "silva";
        this.Idade = 23;
    }
    public Pessoa(string nome, int idade){
        this.Nome = nome;
        this.Sobrenome = "Não informado";
        this.Idade = idade;
    }
    private string? Nome{get;set;}
    private string? Sobrenome{get;set;}
    private int Idade{get;set;}

    public void InsereNome(string nome){
        this.Nome = nome;
    }
    public void InsereSobrenome(string sobrenome){
        this.Sobrenome= sobrenome;
    }
    public void InsereIdade(int idade){
        this.Idade = idade;
    }
    public void MostraDados(){
        Console.WriteLine("O nome é: " + this.Nome);
        Console.WriteLine("O sobrenome é: " + this.Sobrenome);
        Console.WriteLine("A idade é: " + this.Idade);
    }
        
}



        //Console.WriteLine("Dados Cadastrados:");