namespace Loja.Dominio.Entidades {
    public class FormaDePagamento {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }

        public bool EBoleto {
            get {
                return Id == 1;
            }
        }
    }
}