using AP.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace AP.Data.Acess.Configuretion
{
    public class EditoraConfiguretion : EntityTypeConfiguration<Editora>
    {
        public EditoraConfiguretion()
        {
            ToTable("EDITORA");

            HasKey(k => k.EditoraId);

            Property(x => x.Nome).IsRequired();
            Property(x => x.CEP).IsRequired();
            Property(x => x.Estado).IsRequired();
            Property(x => x.Pais).IsRequired();
            Property(x => x.Endereco).IsRequired();
        }
    }
}
