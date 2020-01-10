using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AP.UI.Web.Controllers
{
    public class BibliotecaController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}