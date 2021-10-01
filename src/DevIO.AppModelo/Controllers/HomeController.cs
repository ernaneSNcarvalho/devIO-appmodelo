using DevIO.AppModelo.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.AppModelo.Controllers
{
    public class HomeController : Controller
    {
        private IPedidoRepository _pedidoRepository;
        public HomeController(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }
        public IActionResult Index()
        {
           var pedido = _pedidoRepository.ObterPedido();
            return View();
        }
    }
}
