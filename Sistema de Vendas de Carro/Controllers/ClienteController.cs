using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sistema_de_Vendas_de_Carro.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        // controller destinado ao cliente (cadastrar,alterar e pedidos)

        public ActionResult Index()
        {
            return View();
        }
    }
}