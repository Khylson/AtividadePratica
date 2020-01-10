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

            HasKey(k => k.EditorId);

            Property(x => x.Nome).IsOptional();
            Property(x => x.CEP).IsRequired();
            Property(x => x.Estado).IsRequired();
            Property(x => x.Pais).IsRequired();
            Property(x => x.Logradour).IsRequired();
        }
    }
}
