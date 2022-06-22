namespace Aula13_Atividade
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Curso DH_CSHARP= new();
          

            Console.WriteLine("Alunos matriculados: ");    //add nomes diferentes
            DH_CSHARP.CadastrarAluno(1,"Pedro","Pedra","781243");
            DH_CSHARP.CadastrarAluno(2,"Aderbal","Silva","999471");
            DH_CSHARP.CadastrarAluno(3, "Marina", "Peixes", "551231");
            DH_CSHARP.CadastrarAluno(4, "Adelaide", "Chavez", "112531");
            DH_CSHARP.CadastrarAluno(5, "Juliano", "Santos", "771122");
            

        }
    }
}
