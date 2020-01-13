using AP.Business.Contract.Interfaces.Base;
using AP.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AP.Business.Contract.Interfaces
{
    public interface IAlunoBusiness : IBase <Aluno>
    {
        Aluno Incluir(Aluno aluno);
        IEnumerable<Aluno> ObterTodos();
    }
}
