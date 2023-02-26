using Microsoft.AspNetCore.Mvc;

namespace ASPNET_Boilerplate.Controllers;

[ApiController]
[Route("/api/users")]
public class UserController : ControllerBase {
  [HttpGet]
  [Route("/api/users/all")]
  public IActionResult Get() {
    object person = new {
      name = "John Doe",
      age = 45
    };

    return Ok(person);
  }
}
