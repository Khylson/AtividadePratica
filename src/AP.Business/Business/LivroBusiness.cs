using AP.Business.Base;
using AP.Business.Contract.Interfaces;
using AP.Data.Acess.DataContext;
using AP.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AP.Business.Business
{
    public class LivroBusiness : MainBusiness<Livro>, ILivroBusiness
    {
        public LivroBusiness(DataContext dbContext) : base(dbContext)
        {
        }
    }
}
