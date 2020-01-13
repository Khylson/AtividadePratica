using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AP.Business.Contract.Interfaces;
using AP.Data.Acess.DataContext;
using AP.Model.Models;
using Microsoft.AspNetCore.Mvc;

namespace AP.UI.Web.Controllers
{
    public class AlunoController : Controller 
    {
        private readonly DataContext dbCtx;
        public AlunoController(DataContext dataContext)
        {
            dbCtx = dataContext;
        }
        //private readonly IAlunoBusiness _alunoBusiness;

        //public AlunoController(IAlunoBusiness alunoBusiness)
        //{
        //    _alunoBusiness = alunoBusiness;
        //}

        public IActionResult Index()
        {
            var model = new Autor();
            return View("Forms", model);
        }

        [HttpPost]
        public IActionResult Incluir(Aluno aluno)
        {
            //var model = _alunoBusiness.Incluir(aluno);

            try
            {
                var model = new Aluno
                {
                    Nome = aluno.Nome,
                    Sobrenome = aluno.Sobrenome,
                    Sexo = aluno.Sexo,
                    RA = aluno.RA,
                    CPF = aluno.CPF,
                    Email = aluno.Email,
                    Telefone = aluno.Telefone
                };

                dbCtx.Alunos.Add(model);
                dbCtx.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("eroo ao salavar os dados", ex);
            }

            return View("Forms", aluno);
        }
        //public IEnumerable Carregar()
        //{
        //    //return _alunoBusiness.ObterTodos();

        //    var model = dbCtx.Set<Aluno>().AsEnumerable();
        //    return View(model);
        //}
        [HttpGet] 
        public IActionResult Carregar()
        {
            var lista = dbCtx.Alunos.ToList();
            return View("Lista",lista);
        }
    }
}