using Microsoft.AspNetCore.Identity;

namespace WebApp.Data.Identity
{
    public class AppIdentityUserRole : IdentityUserRole<int> { }
    public class AppIdentityUserClaim : IdentityUserClaim<int> { }
    public class AppIdentityUserLogin : IdentityUserLogin<int> { }
    public class AppIdentityRole : IdentityRole<int> { }
    public class AppIdentityUser : IdentityUser<int> { }
    public class AppIdentityUserToken : IdentityUserToken<int> { }
    public class AppIdentityRoleClaim : IdentityRoleClaim<int> { }
}