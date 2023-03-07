namespace exemplo;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        //Console.ReadLine();
        //INSTANCIA DE UM OBJETO DA CLASSE AVIAO
        Aviao tecoteco = new Aviao();

        //USANDO ATRIBUTOS E/OU MÉTODOS DA CLASSE PELO OBJETO CRIADO
        tecoteco.acelerar();

        //MÉTODO SEM RETORNO E COM PARAMETRO
        tecoteco.acelerarParametro(", Sr. Fellipe Manaia");   

        //METODO COM RETORNO E SEM PARAMETRO

        Console.WriteLine(tecoteco.seila());

        //METODO COM RETORNO E COM PARAMETRO
        Console.WriteLine(tecoteco.somar(10,20));
    }
}
