namespace projeto_conta;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto Banco ETEC MCM");
        Conta c = new Conta();
        //c.Saldo = 1000;
        c.Depositar(1000);
        c.Sacar(1600);
        //  com = é Set
        // sem igual Get
        c.AjustarLimite(500);

        double valortotal = c.MostrarSaldo();

        //Console.WriteLine("Seu saldo é de " + c.Saldo + " Com limite de " + c.Limite);

        Console.WriteLine("Seu saldo total é de " + valortotal);
        //Console.WriteLine("Seu saldo total é de " + c.Saldo);
        
    }
}
