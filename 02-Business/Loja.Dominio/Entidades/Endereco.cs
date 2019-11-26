using System.Collections.Generic;

namespace Loja.Dominio.Entidades {
    public class Endereco : Entidade {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public override void Validar () {
            var erros = new List<string> ();
            if (UsuarioId == 0) erros.Add ("O usuário não foi definido!");
            if (string.IsNullOrEmpty (CEP)) erros.Add ("O campo CEP não parece válido!");
            if (string.IsNullOrEmpty (Logradouro)) erros.Add ("O campo Logradouro não parece válido!");
            if (string.IsNullOrEmpty (Bairro)) erros.Add ("O campo Bairro não parece válido!");
            if (string.IsNullOrEmpty (Cidade)) erros.Add ("O campo Cidade não parece válido!");
            if (string.IsNullOrEmpty (Estado)) erros.Add ("O campo Estado não parece válido!");
            if (string.IsNullOrEmpty (Pais)) erros.Add ("O campo Pais não parece válido!");
            this.Erros = erros.ToArray ();
        }
    }
}