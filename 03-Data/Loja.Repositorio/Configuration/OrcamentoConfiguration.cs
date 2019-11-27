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

  