using Microsoft.AspNetCore.Identity;

namespace BookListsWebApp.Models;

public class User : IdentityUser
{
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
}
