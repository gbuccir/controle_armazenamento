using System;

namespace controle_armazenamento
{
     class Medicamento : Produto
    {
        public MedicamentoEnum medicamentoTipo { get; set; }
        public float dosagem {get; set;}
    }
}
