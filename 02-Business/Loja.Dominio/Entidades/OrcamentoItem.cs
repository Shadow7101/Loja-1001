using System;

namespace Loja.Dominio.Entidades {
    public class OrcamentoItem {
        public long Id { get; set; }
        public int OrcamentoId { get; set; }
        public virtual Orcamento Orcamento { get; set; }
        public int ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
    }
}