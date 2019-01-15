using System;

namespace controle_armazenamento
{
    public abstract class Produto
    {

        public String itemNome { get; set; }
        public int quantidade { get; set; }
        public String itemDescricao { get; set; }
        public String itemMarca { get; set; }
        public float nomeItem { get; set; }
        public CategoriaEnum categoria { get; set; }
        
        /*public int retornaQuantidade()
        {
            return quantidade * 2;
        }*/
    }
}
