using System.ComponentModel.DataAnnotations;

namespace ASPNET_Boilerplate.Models;

public class User {
  public int Id { get; set; }

  [Required]
  [EmailAddress]
  public string? Email { get; set; }

  [Required]
  public string? Name { get; set; }

  [Required]
  public string? Password { get; set; }

  [Required]
  public string? Username { get; set; }
}
