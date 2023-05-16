namespace exercicio03;
class ContratoPessoaJuridica:Contrato
{

public override double CalcularPrestacao(){
    return ((base.CalcularPrestacao()/Prazo)+3);
   }

  
}