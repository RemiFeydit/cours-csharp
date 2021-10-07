using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pizza.Repositories;
using pizza.Service;
using System.Collections.Generic;
namespace pizza.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PizzaController : ControllerBase
    {
        private readonly ILogger<PizzaController> _logger;

        public PizzaController(ILogger<PizzaController> logger)
        {
            _logger = logger;
        }

        public IEnumerable<Pizza> Get()
        {
            return PizzaService.GetAll();
        }

        [HttpGet]
        [Route("{type}")]
        public IEnumerable<Pizza> GetPizzaType(string type)
        {
            return PizzaService.GetPizzaType(type);
        }
    }
}
