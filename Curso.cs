namespace Aula13_Atividade
{
    class Curso : Administracao
    {
        Dictionary<int, dynamic> alunosCurso = new Dictionary<int, dynamic>();

        public override void Cadastrar()
        {
            alunosCurso.Add(1, "fulano 1");
            alunosCurso.Add(2, "fulano 2");   //aqui diz o nome dos alunos no value, acrescentando eles para o dictionary
            alunosCurso.Add(3, "fulano 3");
        }
        

        public override void Remover()
        {
            alunosCurso.Remove(0);   //remove os alunos pelo num da matricula (key)
        }

        public override void Atualizar()
       {
            if (alunosCurso.ContainsKey(2))     //pra checar se a matricula existe
            {
                alunosCurso[2] = "novofulano";      //dar novo valor a key/matricula
            }

        }

        public override void ApresentarTodos()
        {
            for (int i = 0; i < alunosCurso.Count; i++)
            {
                Console.WriteLine("Matricula: {0}, Nome: {1}", alunosCurso.ElementAt(i).Key, alunosCurso.ElementAt(i).Value);
            }
        }
    }
}
