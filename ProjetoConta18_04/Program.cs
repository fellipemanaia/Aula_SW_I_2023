namespace ProjetoConta18_04;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto Banco ETEC MCM");
        Banco b = new Banco();
        //c.Saldo = 1000;
        b.Depositar(1000);
        b.Sacar(1600);
        //  com = é Set
        // sem igual Get
        b.AjustarLimite(500);

        double valortotal = b.MostrarSaldo();

        //Console.WriteLine("Seu saldo é de " + c.Saldo + " Com limite de " + c.Limite);

        Console.WriteLine("Seu saldo total é de " + valortotal);
        //Console.WriteLine("Seu saldo total é de " + c.Saldo);

        b.imprimi(b.emprestimo(12,1000));
    }
}
