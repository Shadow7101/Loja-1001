using Loja.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Loja.Repositorio.Configuration
{
    internal class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("tblUsuarios");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("UsuarioId");

            builder.Property(x => x.Nome).HasColumnName("Nome").HasColumnType("varchar").HasMaxLength(100).IsRequired();

            builder.Property(x => x.Email).HasColumnName("Email").HasColumnType("varchar").HasMaxLength(100).IsRequired();

            builder.Property(x => x.Senha).HasColumnName("Senha").HasColumnType("varchar").HasMaxLength(400).IsRequired();
        }
    }
}
