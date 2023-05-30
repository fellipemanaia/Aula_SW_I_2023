namespace exercicio2;
class Nacional:Produto
{
    public double Taxa{get;set;}

    
    public override double CalculaValor(){
        double tx = this.Valor*(this.Taxa/100); 
        return base.CalculaValor()+ tx;
    }
}
