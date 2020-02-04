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
    public class EmprestimoController : Controller
    {
        private readonly IEmprestimoBusiness _emprestimoBusiness;

        public EmprestimoController(IEmprestimoBusiness emprestimoBusiness)
        {
            _emprestimoBusiness = emprestimoBusiness;
        }
        public IActionResult Index()
        {
            return View("Forms");
        }
        [HttpPost]
        public IActionResult Incluir(Emprestimo emprestimo)
        {
            var model = _emprestimoBusiness.Incluir(emprestimo);
            return View("Forms", model);
        }
        public IActionResult Consultar(int id)
        {
            var consulta = _emprestimoBusiness.Consultar(id);
            return View("Altarar", consulta);
        }
        public void Alterar(Emprestimo alterar)
        {
            _emprestimoBusiness.Alterar(alterar);
        }
        public IActionResult Carregar()
        {
            var carregar = _emprestimoBusiness.Listar();
            return View("Lista", carregar);
        }
        public void Excluir(Emprestimo excluir)
        {
            _emprestimoBusiness.Excluir(excluir);
        }


    }
}