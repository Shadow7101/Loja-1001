using System;
using System.Collections.Generic;

namespace Loja.Dominio.Entidades {
    public class Orcamento {
        public int Id { get; set; }
        public int Numero { get; set; }
        public DateTime Data { get; set; }
        public int FormaDePagamentoId { get; set; }
        public virtual FormaDePagamento FormaDePagamento { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public int EnderecoId { get; set; }
        public virtual Endereco Endereco { get; set; }
        public virtual ICollection<OrcamentoItem> Itens { get; set; }
    }
}