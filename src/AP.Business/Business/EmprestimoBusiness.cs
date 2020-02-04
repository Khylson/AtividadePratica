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
    public class EmprestimoBusiness : IBase<Emprestimo>, IEmprestimoBusiness
    {
        private readonly Context dbCtx;

        public EmprestimoBusiness(Context dbContext)
        {
            dbCtx = dbContext;
        }

        public void Alterar(Emprestimo entity)
        {
            dbCtx.Entry(entity).State = EntityState.Modified;
            dbCtx.SaveChanges();
        }

        public void Excluir(Emprestimo entity)
        {
            var delete = dbCtx.Emprestimos.Find(keyValues: entity.EmpId);

            dbCtx.Emprestimos.Remove(delete);
            dbCtx.SaveChanges();
        }
        public Emprestimo Consultar(int id)
        {
            var consulta = dbCtx.Emprestimos.Find(id);
            return consulta;
        }
        public Emprestimo Incluir(Emprestimo emprestimo)
        {
            try
            {
                var model = new Emprestimo
                {
                    EmpId = emprestimo.EmpId,
                    DataEmprestimo = emprestimo.DataEmprestimo,
                    DataDevolucao = emprestimo.DataDevolucao,
                    ValorMulta = emprestimo.ValorMulta,
                    LivroId = emprestimo.LivroId,
                    AlunoId = emprestimo.AlunoId,
                   
                };

                dbCtx.Emprestimos.Add(model);
                dbCtx.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("erro ao salavar os dados", ex);
            }

            return emprestimo;
        }

        public IEnumerable<Emprestimo> Listar()
        {
            var lista = dbCtx.Emprestimos.ToList();
            return lista;
        }

        #region metodos não implementado

        public IEnumerable<Emprestimo> Pesquisar(Expression<Func<Emprestimo, bool>> elemeto)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
