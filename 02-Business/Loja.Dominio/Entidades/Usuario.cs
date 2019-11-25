using System;
using System.Collections.Generic;

namespace Loja.Dominio.Entidades {
    public class Usuario {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Sobrenome { get; set; }
        public ICollection<Endereco> Enderecos { get; set; }
    }
}