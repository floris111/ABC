using Microsoft.AspNetCore.Mvc;

namespace ABCApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class CartonController : ControllerBase
    {
        private static readonly List<Carton> _cartonList = new();

        /// <response code="200">If the posted carton has been accepted</response>
        /// <response code="400">If the posted carton has invalid parameters</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Consumes("application/json")]
        public IActionResult Post([FromBody] Carton carton)
        {
            if(ModelState.IsValid)
            {
                _cartonList.Add(carton);
            } else
            {
                // Log to logging service, not implemented for demo purposes
            }
            return Ok(carton);
        }

    }
}
