using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace APIExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AmbienteController : ControllerBase
    {
        private readonly IConfiguration _config;

        public AmbienteController(IConfiguration config)
        {
            this._config = config;
        }

        public string Get()
        {
            var ambiente = _config.GetValue<string>("CustomSetting");
            return ambiente;
        }
    }
}
