using APIExample.Core.Models;
using System.Collections.Generic;

namespace APIExample.Core.Repositories
{
    public class ClienteRepository
    {
        public static List<Cliente> ListAll()
        {
            var clientes = new List<Cliente>();
            clientes.Add(new Cliente { Id = 1, Nome = "Juãu" });
            clientes.Add(new Cliente { Id = 2, Nome = "Maria" });
            return clientes;
        }
    }
}
