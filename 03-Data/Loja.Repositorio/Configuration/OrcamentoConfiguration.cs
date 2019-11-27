using Loja.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Loja.Repositorio.Configuration
{
    internal class OrcamentoConfiguration : IEntityTypeConfiguration<Orcamento>
    {
        public void Configure(EntityTypeBuilder<Orcamento> builder)
        {
            builder.ToTable("tblOrcamentos");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("OrcamentoId").IsRequired();

            builder.Property(x => x.Numero).IsRequired();

            builder.Property(x => x.Data).HasColumnType("smalldatetime").IsRequired();

            builder.Property(x => x.FormaDePagamentoId).IsRequired();

            builder.HasOne(x => x.FormaDePagamento).WithMany().HasForeignKey(x => x.FormaDePagamentoId);

            builder.Property(x => x.UsuarioId).IsRequired();

            builder.HasOne(x => x.Usuario).WithMany().HasForeignKey(x => x.UsuarioId);

            builder.Property(x => x.EnderecoId).IsRequired();

            builder.HasOne(x => x.Endereco).WithMany().HasForeignKey(x => x.EnderecoId);
        }
    }
}