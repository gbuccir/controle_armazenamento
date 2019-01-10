using System;

namespace controle_armazenamento
{
    class Produto
    {
        
        public int quantidade { get; set; }

        public int retornaQuantidade(){
            return quantidade * 2;
        }
    }
}
