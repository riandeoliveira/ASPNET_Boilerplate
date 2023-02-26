using ASPNET_Boilerplate.Database;
using ASPNET_Boilerplate.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASPNET_Boilerplate.Controllers;

[ApiController]
[Route("/api/users")]
public class UserController : ControllerBase {
  public readonly DataContext _context;

  public UserController(DataContext context) {
    _context = context;
  }

  [HttpGet]
  [Route("/api/users/all")]
  public async Task<ActionResult<List<User>>> GetAllUsers() {
    List<User> users = await _context.Users.ToListAsync();

    return Ok(users);
  }

  [HttpPost]
  [Route("/api/users/register")]
  public async Task<ActionResult<List<User>>> Register(User user) {
    _context.Users.Add(user);

    await _context.SaveChangesAsync();
    List<User> users = await _context.Users.ToListAsync();

    return Ok(users);
  }
}
