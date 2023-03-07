namespace ex_aviao;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("EXERCÍCIO AVIÃO POO");
        Aviao aviao1 = new Aviao();
        
        aviao1.modelo = "Airbus A280";
        aviao1.marca = "Azul";
        
        aviao1.exibir();
        aviao1.acelerar();
        aviao1.exibir();
        aviao1.acelerar();
        aviao1.exibir();
    }
}

