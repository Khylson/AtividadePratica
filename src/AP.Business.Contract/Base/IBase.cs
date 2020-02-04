using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AP.Business.Contract.Base
{
    public interface IBase <TModel> where TModel : class
    {

        IEnumerable<TModel> Listar();
        TModel Incluir(TModel entity);
        TModel Consultar(int id);
        void Alterar(TModel entity);
        void Excluir(TModel entity);
        IEnumerable<TModel> Pesquisar(Expression<Func<TModel, bool>> elemeto);
    }
}
