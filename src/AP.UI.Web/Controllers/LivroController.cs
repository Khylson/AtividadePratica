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
    public class LivroController : Controller
    {
        private readonly ILivroBusiness _livroBusiness;

        public LivroController(ILivroBusiness livroBusiness)
        {
            _livroBusiness = livroBusiness;
        }

        public IActionResult Index()
        {
            return View("Forms");
        }
        [HttpPost]
        public IActionResult Incluir(Livro livro)
        {
            var model = _livroBusiness.Incluir(livro);
            return View("Forms");
        }
        public IActionResult Consultar(int id)
        {
            var consulta = _livroBusiness.Consultar(id);
            return View("Altarar", consulta);
        }
        public void Alterar(Livro alterar)
        {
            _livroBusiness.Alterar(alterar);
        }
        public IActionResult Carregar()
        {
            var carregar = _livroBusiness.Listar();
            return View("Lista", carregar);
        }
        public void Excluir(Livro excluir)
        {
            _livroBusiness.Excluir(excluir);
        }
    }
}