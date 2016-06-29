using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Npgsql;

namespace Sistema_de_Vendas_de_Carro.Models
{
    public class ConnectionBd
    {
        public ConnectionBd()
        {
            connectionBd.Open();
        }

        public NpgsqlConnection connectionBd = new NpgsqlConnection("User ID=postgres;Password=99516118;Host=localhost;Port=5432;Database=VendaCarros;");

    }
}