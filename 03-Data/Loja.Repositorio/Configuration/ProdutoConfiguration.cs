using Loja.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Loja.Repositorio.Configuration
{
    internal class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("tblProdutos");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("ProdutoId").IsRequired();

            builder.Property(x => x.Codigo).HasColumnType("varchar").HasMaxLength(20).IsRequired();

            builder.Property(x => x.Nome).HasColumnType("varchar").HasMaxLength(30).IsRequired();

            builder.Property(x => x.Descricao).HasColumnType("varchar").HasMaxLength(500).IsRequired();

            builder.Property(x => x.DataUltimaCompra).IsRequired();

            builder.Property(x => x.ValorDaUltimaCompraPorPeca).IsRequired();

            builder.Property(x => x.UltimaQuantidadeAdquirida).IsRequired();
        }
    }
}