using AP.Business.Base;
using AP.Business.Contract.Interfaces;
using AP.Data.Acess.DataContext;
using AP.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AP.Business.Business
{
    
    public class AlunoBusiness : MainBusiness <Aluno>, IAlunoBusiness
    {
        public AlunoBusiness(DataContext dbContext) : base(dbContext)
        {
        }

        public IEnumerable<Aluno> ObterTodos()
        {
            return Listar();
        }
        public Aluno Incluir(Aluno aluno)
        {
            try
            {
                var model = new Aluno
                {
                    Nome = aluno.Nome,
                    Sobrenome = aluno.Sobrenome,
                    Sexo = aluno.Sexo,
                    RA = aluno.RA,
                    CPF = aluno.CPF,
                    Email = aluno.Email,
                    Telefone = aluno.Telefone
                };

                dbCtx.Alunos.Add(model);
                dbCtx.SaveChanges();
 
            }
            catch (Exception ex)
            {
                throw new Exception("eroo ao salavar os dados", ex);
            }

            return Incluir(aluno);
        }

       
    }
}
