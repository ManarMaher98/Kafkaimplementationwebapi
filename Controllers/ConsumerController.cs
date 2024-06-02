using Kafkaproducerimplemenation.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KafkaImplementation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly ILogger _logger;

        public InventoryController(ILogger logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult princesAdded([FromBody] Princesrequest request)
        {
            return Ok("princes added processed successfully.");
        }
    }
}
