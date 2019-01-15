using System.Collections.Generic;
using controle_armazenamento;

namespace Classes
{

    public interface IProduto<T> where T : Produto
    {
        void Cadastrar(T document);

        IList<T> Listar();

        T Encontrar(string onde);

        void Update(string onde, T document);

        IList<T> ListarOnde(string onde);

        void Deletar(string onde, T document);
    }

}