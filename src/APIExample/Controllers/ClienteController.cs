using System.Collections.Generic;
using APIExample.Core.Models;
using APIExample.Core.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace APIExample.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            var clientes = ClienteRepository.ListAll();
            return clientes.ToArray();
        }
    }
}
