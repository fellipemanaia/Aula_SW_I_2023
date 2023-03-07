namespace ex_aviao;
class Aviao
{
    public string modelo = "";
    public string marca = "";
    public int velocidade;
    public int altitude;

    public void subir(){
        altitude++;
    }

     public void descer(){
        altitude--;
    }

     public void acelerar(){
        velocidade++;
    }

     public void reduzir(){
        velocidade--;
    }

    public void exibir(){
        Console.WriteLine("Dados do avião:");
        Console.WriteLine("Modelo:" + modelo);
        Console.WriteLine("Marca:" + marca);
        Console.WriteLine("Velocidade atual:" + velocidade);
        Console.WriteLine("Altitude atual:" + altitude);
    }

}