using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Data.Acess.Repositories
{
    public interface IRepository <TModel> where TModel : class
    {
        List<TModel> Listar();
        void Incluir(TModel entity);
        void Alterar(TModel entity);
        void Excluir(TModel entity);
        TModel Consultar(long id);
       // TModel Pesquisar(long id);
        List<TModel> Pesquisar(Expression<Func<TModel, bool>> where);

    }
}
