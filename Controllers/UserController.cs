using Microsoft.AspNetCore.Mvc;

namespace ASPNET_Boilerplate.Controllers;

[ApiController]
[Route("/api/users")]
public class UserController : ControllerBase {
  [HttpGet]
  public IActionResult Get() {
    object person = new {
      name = "John Doe",
      age = 45
    };

    int i = 0;
    string name = "John";

    Console.WriteLine(i);
    Console.WriteLine(name);

    return Ok(person);
  }
}
