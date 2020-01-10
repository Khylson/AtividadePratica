using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Data.Acess.Repositories
{
    public interface IRepository <TModel> where TModel : class
    {
        IEnumerable<TModel> Listar();
        TModel Incluir(TModel entity);
        TModel Consultar(long id);
        void Alterar(TModel entity);
        void Excluir(TModel entity);
        IEnumerable<TModel> Pesquisar(Expression<Func<TModel, bool>> elemeto);

    }
}
