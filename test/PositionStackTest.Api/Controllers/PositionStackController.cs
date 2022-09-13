using Microsoft.AspNetCore.Mvc;
using PositionStack;

namespace PositionStackTest.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PositionStackController : ControllerBase
    {
        private readonly ILogger<PositionStackController> _logger;
        private readonly IPositionStackClient _positionStackClient;

        public PositionStackController(ILogger<PositionStackController> logger,
                                         IPositionStackClient positionStackClient)
        {
            _logger = logger;
            _positionStackClient = positionStackClient;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var result = await _positionStackClient.SearchAsync("rua rego barros 03460-000");

            return Ok(result.Content);
        }
    }
}