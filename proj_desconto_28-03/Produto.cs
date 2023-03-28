namespace projeto_desconto;
class Produto
{
    public Produto(){
        this.Nome = "TICTOC";
        this.Preco = 15;
    }
    public Produto(string nome){
        this.Nome = nome;
        this.Preco = 10;
    }
    public Produto(string nome, int desconto){
        this.Nome = nome;
        this.Preco = 10-(10*desconto/100);
    }
    private string? Nome {get;set;}
    private double Preco {get;set;} 

    public void CadastraNome(string nome){
        this.Nome = nome;
    }
    public void CadastraPreco(double preco){
        this.Preco = preco;
    }

    public void mostraDados(){
        Console.WriteLine("Produto: " + this.Nome);
        Console.WriteLine("Preço: " + this.Preco);
    }
}