using AP.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace AP.Data.Acess.Configuretion
{
    public class EmprestimoConfiguretion : EntityTypeConfiguration<Emprestimo>
    {
        public EmprestimoConfiguretion()
        {
            ToTable("EMPRESTIMO");

            HasKey(k => k.EmpId);

            Property(x => x.DataEmprestimo).IsRequired();
            Property(x => x.DataDevolucao).IsRequired();
            Property(x => x.ValorMulta).IsOptional();

            HasRequired(x => x.Livros).WithMany().HasForeignKey(x => x.LivroId);
            HasRequired(x => x.Alunos).WithMany().HasForeignKey(x => x.AlunoId);
        }
    }
}
