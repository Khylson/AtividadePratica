using Data.Acess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AP.Business.Base
{
    public class MainBusiness<T> : IRepository<T> where T : class
    {
        #region CRUD BUSINESS BASE
        public void Alterar(T entity)
        {
            throw new NotImplementedException();
        }

        public T Consultar(long id)
        {
            throw new NotImplementedException();
        }

        public void Excluir(T entity)
        {
            throw new NotImplementedException();
        }

        public void Incluir(T entity)
        {
            throw new NotImplementedException();
        }

        public List<T> Listar()
        {
            throw new NotImplementedException();
        }

        public List<T> Pesquisar(Expression<Func<T, bool>> where)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
