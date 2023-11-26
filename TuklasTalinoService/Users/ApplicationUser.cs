using Microsoft.AspNetCore.Identity;

namespace TuklasTalinoService.Users
{
    public class ApplicationUser: IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime Birthday { get; set; }
    }
}
