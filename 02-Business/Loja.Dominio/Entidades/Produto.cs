using System;

namespace Loja.Dominio.Entidades {
    public class Produto {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string DescricaoLonga { get; set; }
        public DateTime DataUltimaCompra { get; set; }
        public decimal ValorDaUltimaCompraPorPeca { get; set; }
        public int UltimaQuantidadeAdquirida { get; set; }
    }
}