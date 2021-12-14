using System.Collections.Generic;
namespace CadastroSeries.Interfaces

{
    public interface IRepositorio<T>
    {
        List<T> Listar();
        T RetornarPorId(int id);
        void Inserir(T objeto);
        void Excluir(int id);
        void Atualizar(int id, T objeto);
        int ProximoId();

    }
}