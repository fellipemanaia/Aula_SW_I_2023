namespace exercicio03;
class Contrato

{
   public string? Tipo {get;set;}

   public long Cpf {get;set;}

   public int Idade {get;set;}

   public long Inscricao {get;set;}

   public long Cnpj {get;set;}

   public int Prazo {get;set;}


   public virtual double CalcularPrestacao(){
        return 1000;
    }
}


