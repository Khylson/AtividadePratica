using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AP.Business.Contract.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AP.UI.Web.Controllers
{
    public class EditorController : Controller
    {
        private readonly IEditoraBusiness _editoraBusiness;

        public EditorController(IEditoraBusiness editoraBusiness)
        {
            _editoraBusiness = editoraBusiness;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}