using System;
using System.Collections.Generic;

namespace Loja.Dominio.Entidades
{
    public class OrcamentoItem : Entidade
    {
        public long Id { get; set; }
        public int OrcamentoId { get; set; }
        public virtual Orcamento Orcamento { get; set; }
        public int ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public override void Validar()
        {
            var erros = new List<string>();
            if (OrcamentoId == 0) erros.Add("O Orçamento não foi definido!");
            if (ProdutoId == 0) erros.Add("O Produto não foi definido!");
            if (Quantidade == 0) erros.Add("A quantidade não foi definido!");
            if (ValorUnitario == 0) erros.Add("O valor unitário!");
            this.Erros = erros.ToArray();
        }
    }
}