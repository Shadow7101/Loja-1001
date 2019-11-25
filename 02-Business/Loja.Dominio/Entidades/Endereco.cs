namespace Loja.Dominio.Entidades {
    public class Endereco {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
    }
}