namespace exemplo;
class Aviao
{
   public string modelo="";
   public string marca="";
   public int velocidade;
   public int altitude;


   public void acelerar(){
     Console.WriteLine("Estou acelerando!!!");
   }
   public void acelerarParametro(string valor){
     Console.WriteLine("Estou acelerando!!!" + valor);
   }

   public string seila(){
    return "Estou a seu serviço Sr. Fellipe Manaia";
   }
    public int somar(int a, int b){
    int soma = a+ b;
    return a+b;
   }
   
   
   
   
}