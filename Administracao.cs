namespace Aula13_Atividade
{
    abstract class Administracao
    {
        public abstract void Cadastrar();
        
       public abstract void Remover();

        public virtual void Atualizar()
        {

        }

        public virtual void ApresentarTodos()
        {

        }
    }
}
