using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sistema_de_Vendas_de_Carro.Models;

namespace Sistema_de_Vendas_de_Carro.CRUDs
{
    public class CarroCrud :ICrud<Carro>
    {
        public void MetodoSalvar(Carro entidade)
        {
            
        }

        public void MetodoAlterar(Carro entidade)
        {
            throw new NotImplementedException();
        }

        public void MetodoDeletar(string Id)
        {
            throw new NotImplementedException();
        }

        public Carro MetodoBuscarPorId(string Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Carro> MetodoRetornaListaTotal()
        {
            throw new NotImplementedException();
        }
    }
}