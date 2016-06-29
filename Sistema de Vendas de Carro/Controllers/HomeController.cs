using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sistema_de_Vendas_de_Carro.Controllers
{
    public class HomeController : Controller
    {
        // Projeto Iniciado
        // controller destinado a listar os carros para os clientes
        public ActionResult Index()
        {
            return View();
        }
    }
}