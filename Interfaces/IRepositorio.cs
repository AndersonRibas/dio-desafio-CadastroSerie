using System.Collections.Generic;
namespace CadastroSeries.Interfaces

{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorId(int id);
        void Inseri(T objeto);
        void Excluir(int id);
        void Atualizar(int id, T objeto);
        int ProximoId();

    }
}