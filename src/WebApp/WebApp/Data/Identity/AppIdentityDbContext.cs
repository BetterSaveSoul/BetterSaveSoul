using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Data.Identity
{
    public class AppIdentityDbContext(DbContextOptions options) : IdentityDbContext<AppIdentityUser, AppIdentityRole, int,
        AppIdentityUserClaim, AppIdentityUserRole, AppIdentityUserLogin
        , AppIdentityRoleClaim, AppIdentityUserToken>(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Apply configurations
        }
    }
}
