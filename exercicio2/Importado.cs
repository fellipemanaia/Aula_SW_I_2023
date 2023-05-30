namespace exercicio2;
class Importado:Produto
{
    public double Taxa{get;set;}
    public double TaxaImport{get;set;}

    public override double CalculaValor(){
        double tx = this.Valor*(this.Taxa/100); 
        double tximp = this.Valor*(this.Taxa/100);  
        return base.CalculaValor()+ tx + tximp;
    }
}
