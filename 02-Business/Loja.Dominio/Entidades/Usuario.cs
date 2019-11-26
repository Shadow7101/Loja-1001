using System;
using System.Collections.Generic;

namespace Loja.Dominio.Entidades {
    public class Usuario : Entidade {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public ICollection<Endereco> Enderecos { get; set; }
        public override void Validar () {
            var erros = new List<string> ();
            if (string.IsNullOrEmpty (Nome)) erros.Add ("O campo Nome não parece válido!");
            if (string.IsNullOrEmpty (Email)) erros.Add ("O campo Email não parece válido!");
            if (string.IsNullOrEmpty (Senha)) erros.Add ("O campo Senha não parece válido!");
            this.Erros = erros.ToArray ();
        }
    }
}