namespace exercicio2;
class Program
{
    
    static void Main(string[] args)
    {
        Produto p = new Produto();
    
        Estadual e = new Estadual();
    
        Nacional n = new Nacional();
    
        Importado i = new Importado(); 


        
        string? Escolha = string.Empty;
        while(Escolha != "Estadual" && Escolha != "Nacional" && Escolha != "Importado"){
            Console.Clear();
            Console.WriteLine("Escolha entre produto Estadual, Nacional ou Importado");
            Escolha = Console.ReadLine();
        }
        switch (Escolha){

            //ESTADUAL
            case "Estadual":
                Console.WriteLine("Digite a descrição do Produto Estadual");
                e.Descricao = Console.ReadLine();

                Console.WriteLine("Digite o Valor do Produto Estadual");
                e.Valor = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o Valor do Imposto Produto Estadual");
                e.Imposto = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(e.CalculaValor());
            break;
            
            //NACIONAL
            case "Nacional":
                Console.WriteLine("Digite a descrição do Produto Nacional");
                n.Descricao = Console.ReadLine();

                Console.WriteLine("Digite o Valor do Produto Nacional");
                n.Valor = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o Valor do Imposto Produto Nacional");
                n.Imposto = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o Valor da Taxa Produto Nacional");
                n.Taxa = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(n.CalculaValor());
            break;

            //IMPORTADO
            case "Importado":
                Console.WriteLine("Digite a descrição do Produto Importado");
                i.Descricao = Console.ReadLine();

                Console.WriteLine("Digite o Valor do Produto Importado");
                i.Valor = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o Valor do Imposto Produto Importado");
                i.Imposto = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o Valor da Taxa Produto Importado");
                i.Taxa = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o Valor da Taxa Importadora Produto Importado");
                i.Taxa = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(i.CalculaValor());
            break;
        }
    }
}
