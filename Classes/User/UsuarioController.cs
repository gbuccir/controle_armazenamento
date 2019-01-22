using System;
using System.Collections.Generic;
using System.Linq;
using Classes;
using controle_armazenamento;
//using controle_armazenamento;


namespace UsuarioController
{

    public class UsuarioController : IProduto<Usuario>
    {
        public UsuarioController()
        {
        }

        private String tabela { get; set; }

        public void Cadastrar(Produto document)
        {
            try
            {
                var x = (from y in tabela
                         select new Medicamento());
            }
            catch (Exception)
            {

                throw new NotImplementedException();
            }
        }

        public void Cadastrar(Usuario document)
        {
            throw new NotImplementedException();
        }

        public void Deletar(string onde, Produto document)
        {
            throw new NotImplementedException();
        }

        public void Deletar(string onde, Usuario document)
        {
            throw new NotImplementedException();
        }

        public Produto Encontrar(string onde)
        {
            throw new NotImplementedException();
        }

        public IList<Produto> Listar()
        {
            throw new NotImplementedException();
        }

        public IList<Produto> ListarOnde(string onde)
        {
            throw new NotImplementedException();
        }

        public void Update(string onde, Produto document)
        {
            throw new NotImplementedException();
        }

        public void Update(string onde, Usuario document)
        {
            throw new NotImplementedException();
        }

        Usuario IProduto<Usuario>.Encontrar(string onde)
        {
            throw new NotImplementedException();
        }

        IList<Usuario> IProduto<Usuario>.Listar()
        {
            throw new NotImplementedException();
        }

        IList<Usuario> IProduto<Usuario>.ListarOnde(string onde)
        {
            throw new NotImplementedException();
        }
    }

}