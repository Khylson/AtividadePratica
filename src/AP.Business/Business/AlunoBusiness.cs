using AP.Business.Base;
using AP.Business.Contract.Interfaces;
using AP.Data.Acess.DataContext;
using AP.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AP.Business.Business
{
    
    public class AlunoBusiness : MainBusiness <Aluno>, IAluno
    {
        public AlunoBusiness(DataContext dbContext) : base(dbContext)
        {
        }

       
    }
}
