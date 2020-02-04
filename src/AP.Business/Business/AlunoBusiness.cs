using AP.Business.Base;
using AP.Business.Contract.Base;
using AP.Business.Contract.Interfaces;
using AP.Data.Acess.DataContext;
using AP.Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace AP.Business.Business
{
    
    public class AlunoBusiness : IBase<Aluno>, IAlunoBusiness
    {
        private readonly Context dbCtx;

        public AlunoBusiness(Context dbContext) 
        {
            dbCtx = dbContext;
        }

        public Aluno Incluir(Aluno aluno)
        {
            var model = dbCtx.Alunos.Where(x => x.AlunoId == aluno.AlunoId).FirstOrDefault(f => f.AlunoId.Equals(aluno.AlunoId));

            if (model == null)
            {
                 model = new Aluno
                 {
                    AlunoId = aluno.AlunoId,
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
            return aluno;
        }

        public void Alterar(Aluno entity)
        {
            var altera = dbCtx.Alunos.Find(entity.AlunoId);

            dbCtx.Alunos.Update(altera);
            dbCtx.SaveChanges();
        }

        public void Excluir(Aluno entity)
        {
            var delete = dbCtx.Alunos.Find(keyValues: entity.AlunoId);

            dbCtx.Alunos.Remove(delete);
            dbCtx.SaveChanges();
        }

        public IEnumerable<Aluno> Listar()
        {
            var lista = dbCtx.Alunos.ToList();
            return lista;
        }
        public Aluno Consultar(int id)
        {
            var consulta = dbCtx.Alunos.Find(id);
            return consulta;
        }
        #region metodos não implementados 
        public IEnumerable<Aluno> Pesquisar(Expression<Func<Aluno, bool>> elemeto)
        {
            throw new NotImplementedException();
        }
        #endregion não implementado 

    }
}
