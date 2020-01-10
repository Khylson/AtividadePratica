using AP.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace AP.Data.Acess.Configuretion
{
    public class LivroConfiguretion : EntityTypeConfiguration<Livro>
    {
        public LivroConfiguretion()
        {
            ToTable("LIVRO");

            HasKey(k => k.AutorId);

            Property(x => x.Titulo).IsRequired();
            Property(x => x.ISBN).IsRequired();
            Property(x => x.Quantidade).IsRequired();
            Property(x => x.Status).IsRequired();

            HasRequired(x => x.Autores).WithMany().HasForeignKey(x => x.AutorId);
            HasRequired(x => x.Editoras).WithMany().HasForeignKey(x => x.EditoraId);
        }
    }
}
