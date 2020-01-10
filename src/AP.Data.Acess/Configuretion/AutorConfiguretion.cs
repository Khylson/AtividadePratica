using AP.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace AP.Data.Acess.Configuretion
{
    public class AutorConfiguretion : EntityTypeConfiguration<Autor>
    {
        public AutorConfiguretion()
        {
            ToTable("AUTOR");

            HasKey(k => k.AutorId);

            Property(x => x.Nome).IsRequired();
            Property(x => x.Sobrenome).IsRequired();
            Property(x => x.Idade).IsOptional();
        }
    }
}
