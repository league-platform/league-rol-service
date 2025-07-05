using Microsoft.AspNetCore.Mvc;

namespace RolService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PingController : ControllerBase
{
    [HttpGet]
    public IActionResult Get() => Ok("pong 🏓");
}
