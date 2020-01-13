using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AP.Business.Contract.Interfaces;
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
            return View();
        }
    }
}