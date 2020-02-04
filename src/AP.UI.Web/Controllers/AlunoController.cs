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

        private readonly IAlunoBusiness _alunoBusiness;

        public AlunoController(IAlunoBusiness alunoBusiness)
        {
            _alunoBusiness = alunoBusiness;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View("Forms");
        }
        [HttpPost]
        public IActionResult Incluir(Aluno aluno)
        {
            var model = _alunoBusiness.Incluir(aluno);
            return View("Forms", model);
        }
        public IActionResult Consultar(int id)
        {
            var consulta = _alunoBusiness.Consultar(id);
            return View("Alterar", consulta);
        }
        public void Alterar(Aluno alterar)
        {
            _alunoBusiness.Alterar(alterar);
        }
        public IActionResult Carregar()
        {
            var carregar = _alunoBusiness.Listar();
            return View("Lista", carregar);
        }
        public void Excluir(Aluno excluir)
        {
            _alunoBusiness.Excluir(excluir);
        }
        public IActionResult Detalheis(int id)
        {
            var detalheis = _alunoBusiness.Consultar(id);
            return PartialView("Detalheis", detalheis);
        }
    }
}