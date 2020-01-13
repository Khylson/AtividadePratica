using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AP.Business.Contract.Interfaces;
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
            return View();
        }
        
    }
}