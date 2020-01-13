using AP.Data.Acess.DataContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Data.Acess.Repositories
{
    public class Repository<TModel> : IRepository<TModel> where TModel : class
    {

        protected readonly DataContext Ctx;

        public Repository(DataContext dbContext)
        {
            Ctx = dbContext;
        }

        #region CRUD 

        public IEnumerable<TModel> Listar()
        {
              return Ctx.Set<TModel>().AsEnumerable();
        }

        public TModel Adicionar(TModel entity)
        {
            Ctx.Set<TModel>().Add(entity);
            Ctx.SaveChanges();
            return entity;
        }

        public TModel Consultar(long id)
        {
            return Ctx.Set<TModel>().Find(id);
        }

        public void Alterar(TModel entity)
        {
            Ctx.Entry(entity).State = EntityState.Modified;
            Ctx.SaveChanges();
        }

        public void Excluir(TModel entity)
        {
            Ctx.Set<TModel>().Remove(entity);
            Ctx.SaveChanges();
        }

        public IEnumerable<TModel> Pesquisar(Expression<Func<TModel, bool>> elemento)
        {
            return Ctx.Set<TModel>().Where(elemento).AsEnumerable();
        }


        #endregion

    }
}
