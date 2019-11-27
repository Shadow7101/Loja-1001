using Loja.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Loja.Repositorio.Configuration
{
    internal class FormaDePagamentoConfiguration : IEntityTypeConfiguration<FormaDePagamento>
    {
        public void Configure(EntityTypeBuilder<FormaDePagamento> builder)
        {
            builder.ToTable("tblFormaDePagamento");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("FormaDePagamentoId");

            builder.Property(x => x.Nome).HasColumnName("Nome").HasColumnType("varchar").HasMaxLength(100).IsRequired();
        }
    }
}
