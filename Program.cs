namespace Aula13_Atividade
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Curso DH_CSHARP= new();
          

            Console.Write("-[ Inserindo novos alunos ");
            DH_CSHARP.CadastrarAluno(1,"Maria","Jose","555999");
            DH_CSHARP.CadastrarAluno(2,"Jose","Maria","666888");
            DH_CSHARP.CadastrarAluno(3, "Joaquim", "Couves", "777555");
            DH_CSHARP.CadastrarAluno(4, "Pablo", "Picasso", "888444");
            DH_CSHARP.CadastrarAluno(5, "Hugo", "Sanchez", "999333");
            Console.WriteLine("]-");

        }
    }
}
