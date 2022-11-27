using Microsoft.AspNetCore.Mvc;

namespace StreetWorkout.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BaseController : ControllerBase
    {
        protected IActionResult ContentResult(object value, string errorMessage = null)
        {
            if ((value.GetType() == typeof(int) || value.GetType() == typeof(bool)) && value == default)
            {
                return BadRequest(errorMessage ?? string.Empty);
            }

            if (value == null)
            {
                return NotFound(errorMessage ?? string.Empty);
            }

            return Ok(value);
        }
    }
}
