using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sistema_de_Vendas_de_Carro.Controllers
{
    public class GerenciadorController : Controller
    {
        // GET: Gerenciador
        // controller destinado ao gerenciamento dos carros (cadastrar,alterar,excluir e listar)
        public ActionResult Index()
        {
            return View();
        }
    }
}