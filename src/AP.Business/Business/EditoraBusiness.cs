using AP.Business.Base;
using AP.Business.Contract.Base;
using AP.Business.Contract.Interfaces;
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
    public class EditoraBusiness : IBase<Editora>, IEditoraBusiness
    {
        private readonly Context dbCtx;

        public EditoraBusiness(Context dbContext)
        {
            dbCtx = dbContext;
        }
        public Editora Incluir(Editora editora)
        {
            try
            {
                var model = new Editora
                {
                    EditoraId = editora.EditoraId,
                    Nome = editora.Nome,
                    CEP = editora.CEP,
                    Estado = editora.Estado,
                    Pais = editora.Pais,
                    Endereco = editora.Endereco
                };
                dbCtx.Editoras.Add(model);
                dbCtx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("erro ao salavar os dados", ex);
            }

            return editora;
        }
        public void Alterar(Editora entity)
        {
            dbCtx.Entry(entity).State = EntityState.Modified;
            dbCtx.SaveChanges();
        }

        public void Excluir(Editora entity)
        {
            var delete = dbCtx.Alunos.Find(keyValues: entity.EditoraId);

            dbCtx.Alunos.Remove(delete);
            dbCtx.SaveChanges();
        }
        public Editora Consultar(int id)
        {
            var consulta = dbCtx.Editoras.Find(id);
            return consulta;
        }

        public IEnumerable<Editora> Listar()
        {
            var lista = dbCtx.Editoras.ToList();
            return lista;
        }

        #region metodo não implementado 
        public IEnumerable<Editora> Pesquisar(Expression<Func<Editora, bool>> elemeto)
        {
            throw new NotImplementedException();
        }
        #endregion
    }

}

