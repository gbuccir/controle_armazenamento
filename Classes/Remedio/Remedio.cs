using System;

namespace controle_armazenamento
{
     class Remedio : Produto
    {
        public MedicamentoEnum medicamentoTipo { get; set; }
        public float dosagem {get; set;}
    }
}
