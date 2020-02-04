using AP.Business.Base;
using AP.Business.Contract.Interfaces.Base;
using AP.Data.Acess.DataContext;
using AP.Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace AP.Business.Business
{
    public class AutorBusiness : IBase<Autor>, IAutorBusiness
    {
        private readonly Context dbCtx;

        public AutorBusiness(Context dbContext) 
        {
            dbCtx = dbContext;
        }

        public void Alterar(Autor entity)
        {
            dbCtx.Entry(entity).State = EntityState.Modified;
            dbCtx.SaveChanges();
        }

        public void Excluir(Autor entity)
        {
            var delete = dbCtx.Alunos.Find(keyValues: entity.AutorId);

            dbCtx.Alunos.Remove(delete);
            dbCtx.SaveChanges();
        }
        public Autor Consultar(int id)
        {
            var consulta = dbCtx.Autores.Find(id);
            return consulta;
        }
        public Autor Incluir(Autor autor)
        {
            try
            {
                var model = new Autor
                {
                    AutorId = autor.AutorId,
                    Nome = autor.Nome,
                    Sobrenome = autor.Sobrenome,
                    Idade = autor.Idade
                };

                dbCtx.Autores.Add(model);
                dbCtx.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("erro ao salavar os dados", ex);
            }

            return autor;
        }

        public IEnumerable<Autor> Listar()
        {
            var lista = dbCtx.Autores.ToList();
            return lista;
        }

        #region metodos não implementado

        public IEnumerable<Autor> Pesquisar(Expression<Func<Autor, bool>> elemeto)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
