using System;
using System.Collections.Generic;

namespace Loja.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataUltimaCompra { get; set; }
        public decimal ValorDaUltimaCompraPorPeca { get; set; }
        public int UltimaQuantidadeAdquirida { get; set; }

        public override void Validar()
        {
            var erros = new List<string>();
            if (string.IsNullOrEmpty(Codigo)) erros.Add("O campo Codigo não parece válido!");
            if (string.IsNullOrEmpty(Nome)) erros.Add("O campo Nome não parece válido!");
            if (string.IsNullOrEmpty(Descricao)) erros.Add("O campo Descrição não parece válido!");
            this.Erros = erros.ToArray();
        }
    }
}