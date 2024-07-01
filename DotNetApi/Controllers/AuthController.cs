using DotNetApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace DotNetApi.Controllers
{
    [ApiController]
    [Route("api/v1/auth")]
    public class AuthController : Controller
    {
        [HttpPost]
        public IActionResult Auth(string userName, string password)
        {
            if (userName == "yudi" && password == "123456")
            {
                var token = TokenService.GenerateToken(new Domain.Customers.Customer());
                return Ok(token);
            }

            return Unauthorized();
        }
    }
}
