using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Vendas_de_Carro.Models
{
    interface ICrud<T> where T:class //isso esta dizendo que isto sera uma interface de um objeto generico
    {
        // entidade : o nome do objeto a ser salvo
        void MetodoSalvar(T entidade);
        void MetodoAlterar(T entidade);
        void MetodoDeletar(string Id);
        T MetodoBuscarPorId(string Id);
        IEnumerable<T> MetodoRetornaListaTotal();
    }
}
