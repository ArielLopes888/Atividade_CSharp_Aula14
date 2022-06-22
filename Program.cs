namespace Aula13_Atividade
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Curso cadastros= new();
          

           Console.WriteLine("Alunos matriculados no curso: ");
            cadastros.Cadastrar();
            cadastros.Atualizar();
            cadastros.Remover();
            cadastros.ApresentarTodos();
           

      

        }
    }
}
