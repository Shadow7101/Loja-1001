using System;
using System.Collections.Generic;

namespace Loja.Dominio.Entidades {
    public class Orcamento : Entidade {
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

        public Orcamento () {
            Data = DateTime.Now;
        }

        public override void Validar () {
            var erros = new List<string> ();
            if (FormaDePagamentoId == 0) erros.Add ("A forma de pagamento não foi definida!");
            if (UsuarioId == 0) erros.Add ("O usuário não foi definido!");
            if (EnderecoId == 0) erros.Add ("O endereço não foi definido!");
            if (Itens.Count == 0) erros.Add ("Não há produtos no pedido!");
            this.Erros = erros.ToArray ();
        }
    }
}