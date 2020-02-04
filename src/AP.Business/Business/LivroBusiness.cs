using AP.Business.Base;
using AP.Business.Contract.Base;
using AP.Business.Contract.Interfaces;
using AP.Business.Enum;
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
    public class LivroBusiness : IBase<Livro>, ILivroBusiness
    {
        private readonly Context dbCtx;

        public LivroBusiness(Context dbContext) 
        {
            dbCtx = dbContext;
        }

        public void Alterar(Livro entity)
        {
            dbCtx.Entry(entity).State = EntityState.Modified;
            dbCtx.SaveChanges();
        }

        public void Excluir(Livro entity)
        {
            var delete = dbCtx.Livros.Find(keyValues: entity.LivroId);

            dbCtx.Livros.Remove(delete);
            dbCtx.SaveChanges();
        }
        public Livro Consultar(int id)
        {
            var consulta = dbCtx.Livros.Find(id);
            return consulta;
        }
        public Livro Incluir(Livro livro)
        {

            try
            {
                var model = new Livro
                {
                    LivroId = livro.LivroId,
                    Titulo = livro.Titulo,
                    ISBN = livro.ISBN,
                    Status = livro.Status,
                    EditoraId = livro.EditoraId,
                    AutorId = livro.AutorId,
                    Quantidade = livro.Quantidade
                };

                dbCtx.Livros.Add(model);
                dbCtx.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("erro ao salavar os dados", ex);
            }

            return livro;
        }

        public IEnumerable<Livro> Listar()
        {
            var lista = dbCtx.Livros.ToList();
            return lista;
        }

        #region metodos não implementado

        public IEnumerable<Livro> Pesquisar(Expression<Func<Livro, bool>> elemeto)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
