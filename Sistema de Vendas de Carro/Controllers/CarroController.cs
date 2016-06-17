using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sistema_de_Vendas_de_Carro.Models;

namespace Sistema_de_Vendas_de_Carro.Controllers
{
    public class CarroController : Controller
    {
        public static List<Carro> ListaDeCarros = new List<Carro>(); // como ainda nao temos o banco de dados vamos usar esta lista estatica 
        public ActionResult Index()
        {
            return View(ListaDeCarros);
        }

        public ActionResult CadastrarCarro()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CadastrarCarro(Carro carro)
        {
            if (ModelState.IsValid)//isso serve para validar os DataAnotations do model
            {
                ListaDeCarros.Add(carro);
                return RedirectToAction("Index");
            }
            return View(carro);
        }

        public ActionResult DetalheCarro(string id)
        {
            var carroTemporario = ListaDeCarros.FirstOrDefault(x => x.Chassi == id);//isso vai retornar o carro com o chassi desejado (Obs: como nao estamos usando banco de dados ainda nao tente repetir o chassi pois ele sera usado como id e é unico para cada carro
            if (carroTemporario!=null)
            {
                return View(carroTemporario);
            }
            return HttpNotFound();
        }

        public ActionResult EditarCarro(string id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult EditarCarro(Carro carro)
        {
            return View();
        }
    }
}