using Microsoft.AspNetCore.Identity;

namespace WebUI.DAL
{
    public class AppUser:IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
