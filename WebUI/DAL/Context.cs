using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebUI.DAL
{
    public class Context:IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server =DESKTOP-PK98KLS; Database = IdentityRoleDb; Trusted_Connection = True;TrustServerCertificate=True;");
        }

        public DbSet<Product> Products { get; set; }
    }
}
