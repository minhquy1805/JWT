using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWTProject.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DataController : ControllerBase
    {
        [HttpGet]

        public IActionResult GetProtectedData()
        {
            return Ok(new { message = "This is protected data." });
        }

        [HttpGet("public")]
        [AllowAnonymous]
        public IActionResult GetPublicData()
        {
            return Ok(new { message = "This is public data." });
        }
    }
}
