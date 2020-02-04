using AP.Business.Contract.Base;
using AP.Data.Acess.DataContext;
using Data.Acess.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace AP.Business.Base
{
    public class MainBusiness<TModel> : IBase<TModel> where TModel : class
    {
        
        protected readonly Context dbCtx;

        public MainBusiness(Context dbContext)
        {
            dbCtx = dbContext;
        }

        #region CRUD BUSINESS BASE

        public IEnumerable<TModel> Listar()
        {
            return dbCtx.Set<TModel>().AsEnumerable();
        }

        public TModel Incluir(TModel entity)
        {
            dbCtx.Set<TModel>().Add(entity);
            dbCtx.SaveChanges();
            return entity;
        }

        public TModel Consultar(int id)
        {
            return dbCtx.Set<TModel>().Find(id);
        }

        public void Alterar(TModel entity)
        {
            dbCtx.Entry(entity).State = EntityState.Modified;
            dbCtx.SaveChanges();
        }

        public void Excluir(TModel entity)
        {
            dbCtx.Set<TModel>().Remove(entity);
            dbCtx.SaveChanges();
        }

        public IEnumerable<TModel> Pesquisar(Expression<Func<TModel, bool>> elemento)
        {
            return dbCtx.Set<TModel>().Where(elemento).AsEnumerable();
        }

        #endregion
    }
}
