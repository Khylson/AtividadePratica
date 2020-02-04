using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AP.Business.Contract.Interfaces.Base;
using AP.Data.Acess.DataContext;
using AP.Model.Models;
using Microsoft.AspNetCore.Mvc;

namespace AP.UI.Web.Controllers
{
    public class AutorController : Controller
    {
        private readonly IAutorBusiness _autorBusiness;

        public AutorController(IAutorBusiness autorBusiness)
        {
            _autorBusiness = autorBusiness;
        }

        public IActionResult Index()
        {
            return View("Forms");
        }
        [HttpPost]
        public IActionResult Incluir(Autor autor)
        {
            var model = _autorBusiness.Incluir(autor);
            return View("Forms", model);
        }
        public IActionResult Consultar(int id)
        {
            var consulta = _autorBusiness.Consultar(id);
            return View("Altarar", consulta);
        }
        public void Alterar(Autor alterar)
        {
            _autorBusiness.Alterar(alterar);
        }
        public IActionResult Carregar()
        {
            var carregar = _autorBusiness.Listar();
            return View("Lista", carregar);
        }
        public void Excluir(Autor excluir)
        {
            _autorBusiness.Excluir(excluir);
        }
    }
}