using System;
using System.Collections.Generic;
using System.Text;
using Loja.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Loja.Repositorio.Configuration
{
    internal class EnderecoConfiguration : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("tblEndereco");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("EnderecoId");

            builder.Property(x => x.UsuarioId).IsRequired();

            builder.HasOne(x => x.Usuario).WithMany(x => x.Enderecos).HasForeignKey(x => x.UsuarioId);

            builder.Property(x => x.CEP).HasMaxLength(10).HasColumnType("char").IsRequired();

            builder.Property(x => x.Logradouro).HasMaxLength(100).HasColumnType("varchar").IsRequired();

            builder.Property(x => x.Bairro).HasMaxLength(100).HasColumnType("varchar").IsRequired();

            builder.Property(x => x.Bairro).HasMaxLength(100).HasColumnType("varchar").IsRequired();

            builder.Property(x => x.Cidade).HasMaxLength(100).HasColumnType("varchar").IsRequired();

            builder.Property(x => x.Estado).HasMaxLength(50).HasColumnType("varchar").IsRequired();

            builder.Property(x => x.Pais).HasMaxLength(50).HasColumnType("varchar").IsRequired();
        }
    }
}
