using Data.Acess.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace AP.Business.Contract.Interfaces.Base
{
    public interface IBase<TModel> : IRepository<TModel> where TModel : class
    {
    }
}
