using System.Collections.Generic;

namespace Loja.Dominio.Entidades
{
    public class FormaDePagamento : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }

        public bool EBoleto
        {
            get
            {
                return Id == 1;
            }
        }

        public override void Validar()
        {
            var erros = new List<string>();
            if (string.IsNullOrEmpty(Nome)) erros.Add("O campo Nome não parece válido!");
            this.Erros = erros.ToArray();
        }
    }
}