using AP.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace AP.Data.Acess.Configuretion
{
    public class AlunoConfiguretion : EntityTypeConfiguration<Aluno>
    {
        public AlunoConfiguretion()
        {
            ToTable("ALUNO");

            HasKey(k => k.AlunoId);

            Property(x => x.Nome).IsRequired();
            Property(x => x.Sobrenome).IsRequired();
            Property(x => x.Sexo).IsRequired();
            Property(x => x.RA).IsRequired();
            Property(x => x.CPF).IsRequired();
            Property(x => x.Email).IsRequired();
            Property(x => x.Telefone).IsOptional();
        }
    }
}
