using Loja.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Loja.Repositorio.Configuration
{
    internal class OrcamentoItemConfiguration : IEntityTypeConfiguration<OrcamentoItem>
    {
        public void Configure(EntityTypeBuilder<OrcamentoItem> builder)
        {
            builder.ToTable("tblOrcamentoItens");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("OrcamentoItemId").IsRequired();

            builder.Property(x => x.OrcamentoId).IsRequired();

            builder.HasOne(x => x.Orcamento).WithMany(x => x.Itens).HasForeignKey(x => x.OrcamentoId);

            builder.Property(x => x.ProdutoId).IsRequired();

            builder.HasOne(x => x.Produto).WithMany().HasForeignKey(x => x.ProdutoId);

            builder.Property(x => x.Quantidade).IsRequired();

            builder.Property(x => x.ValorUnitario).IsRequired();
        }
    }
}