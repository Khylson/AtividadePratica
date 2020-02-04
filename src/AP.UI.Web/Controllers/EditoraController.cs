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
    public class EditoraController : Controller
    {
        private readonly IEditoraBusiness _editoraBusiness;

        public EditoraController(IEditoraBusiness editoraBusiness)
        {
            _editoraBusiness = editoraBusiness;
        }

        public IActionResult Index()
        {
            return View("Forms");
        }
        [HttpPost]
        public IActionResult Incluir(Editora editora)
        {
            var model = _editoraBusiness.Incluir(editora);
            return View("Forms", model);
        }
        public IActionResult Consultar(int id)
        {
            var consulta = _editoraBusiness.Consultar(id);
            return View("Altarar", consulta);
        }
        public void Alterar(Editora alterar)
        {
            _editoraBusiness.Alterar(alterar);
        }
        public IActionResult Carregar()
        {
          var carregar = _editoraBusiness.Listar();
            return View("Lista", carregar);
        }
        public void Excluir(Editora excluir)
        {
            _editoraBusiness.Excluir(excluir);
        }
        
    }
}