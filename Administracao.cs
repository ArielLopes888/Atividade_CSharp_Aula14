namespace Aula13_Atividade
{
    abstract class Administracao
    {
        abstract void Cadastrar();
        
        abstract void Remover();

        virtual void Atualizar()
        {

        }

        virtual void ApresentarTodos()
        {

        }
    }
}
