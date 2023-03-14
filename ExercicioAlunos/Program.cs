namespace ExercicioAlunos;
class Program
{
    static void Main(string[] args)
    {
        Alunos aluno1= new Alunos();
       //nome
        Console.WriteLine("Digite seu nome:");
        aluno1.nome = Console.ReadLine();

       //nota 1
        Console.WriteLine("Digite sua primeira nota:");
        aluno1.nota1 = double.Parse(Console.ReadLine());
       
       //nota 2
        Console.WriteLine("Digite sua segunda nota:");
        aluno1.nota2 = double.Parse(Console.ReadLine());


        //mensagem
        aluno1.mensagem();
    }
}
