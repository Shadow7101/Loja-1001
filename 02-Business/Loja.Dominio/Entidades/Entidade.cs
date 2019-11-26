namespace Loja.Dominio.Entidades
{
    public abstract class Entidade
    {
        public string[] Erros { get; set; }

        public abstract void Validar();

        public bool EhValido
        {
            get
            {
                Validar();
                return (Erros.Length == 0);
            }
        }
    }
}