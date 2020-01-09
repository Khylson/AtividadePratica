using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Text;

namespace Data.Acess.Repositories
{
    public class Repository<TModel> : IRepository<TModel> where TModel : class
    {

        //public DataContext context { get; set; }
        public DbSet<TModel> DbSet { get; set; }

        public Repository()
        {
           // context = _dataContext;
           // DbSet = context.Set();
        }


        #region CRUD 

        public List<TModel> Listar()
        {
            throw new NotImplementedException();
        }

        public void Incluir(TModel entity)
        {
            throw new NotImplementedException();
        }

        public void Alterar(TModel entity)
        {
            throw new NotImplementedException();
        }

        public void Excluir(TModel entity)
        {
            throw new NotImplementedException();
        }

        public TModel Consultar(long id)
        {
            throw new NotImplementedException();
        }

        public List<TModel> Pesquisar(Expression<Func<TModel, bool>> where)
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
