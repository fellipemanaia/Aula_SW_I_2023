namespace exercicio01;
class Program
{
    static void Main(string[] args)
    {
        Animal a = new Animal();
        Homem h = new Homem();
        Cao c = new Cao();
        Gato g = new Gato();


        Console.WriteLine("A fala do homem é: " + h.Fala());
        Console.WriteLine("A fala do cão é: " + c.Fala());
        Console.WriteLine("A fala do gato é: " + g.Fala());
    }
}
