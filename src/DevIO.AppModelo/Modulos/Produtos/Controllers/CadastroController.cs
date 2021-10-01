using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.AppModelo.Modulos.Produtos.Controllers
{
    [Area("Produtos")]
    public class CadastroController : Controller
    {
        [Route("lista")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("busca")]
        public IActionResult Busca()
        {
            return View();
        }
    }
}
