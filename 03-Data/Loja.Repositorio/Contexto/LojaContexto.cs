using Loja.Dominio.Entidades;
using Loja.Repositorio.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Loja.Repositorio.Contexto
{
    public class LojaContexto : DbContext
    {
        public LojaContexto(DbContextOptions options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<FormaDePagamento> FormasDePagamento { get; set; }
        public DbSet<Orcamento> Orcamentos { get; set; }
        public DbSet<OrcamentoItem> OrcamentoItens { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new EnderecoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaDePagamentoConfiguration());
            model