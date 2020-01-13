using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AP.Business.Contract.Interfaces.Base;
using AP.Model.Models;
using Microsoft.AspNetCore.Mvc;

namespace AP.UI.Web.Controllers
{
    public class AutorController : Controller
    {
        private readonly IAutorBusiness _autorBusiness;

        public AutorController (IAutorBusiness autorBusiness)
        {
            _autorBusiness = autorBusiness;
        }
        public IActionResult Index()
        {
            var model = new Autor();
            return View("Forms", model);
        }
    }
}