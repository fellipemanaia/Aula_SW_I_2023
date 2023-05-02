namespace heranca_polimorfismo;
class FuncionarioN3:Funcionario
{
   public string? Cargo {get;set;}
    public override double Participacao(){
    return base.Participacao() * 0.03;

   }
}
