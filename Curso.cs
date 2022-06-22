namespace Aula13_Atividade
{
    class Curso: Administracao
    {
        Dictionary<int, Aluno> Cadastrados = new Dictionary<int, Aluno>();
        
        public bool CadastrarAluno(int NumeroMatricula, string? Nome, string? Sobrenome, string Telefone)
        {
            Aluno NossoAluno = new Aluno();
            NossoAluno.Matricula = NumeroMatricula;
            NossoAluno.Nome = Nome;
            NossoAluno.Sobrenome = Sobrenome;
            NossoAluno.Telefone = Telefone;

            Cadastrados.TryAdd(NumeroMatricula, NossoAluno);

            return true;
        }

        public override void Remover(bool NossoAluno)
        {
            Cadastrados.Remove(NossoAluno);
        }

        public override void Atualizar()
        {
            Aluno[1] = (6, "Creuza", "Batatas", "00000");

        }

        public override void ApresentarTodos()
        {
            foreach (var item in Cadastrados)
            {
                Console.WriteLine($"{item.Key} - {item.Value.Nome} {item.Value.Sobrenome}");
            }
        }
    }
}
