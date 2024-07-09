using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Models.Core.Models;

namespace DataAccess.EF
{
    public class AppDbContext (DbContextOptions options) : IdentityDbContext<AppUser> (options)
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<AppUser>()
                .ToTable("User", "Security");
            builder.Entity<IdentityRole>()
                .ToTable("Role", "Security");
            builder.Entity<IdentityUserRole<string>>()
                .ToTable("UserRoles", "Security");
            builder.Entity<IdentityUserClaim<string>>()
                .ToTable("UserClaims", "Security");
            builder.Entity<IdentityUserLogin<string>>()
                .ToTable("UserLogins", "Security");
            builder.Entity<IdentityUserToken<string>>()
                .ToTable("UserTokens", "Security");
            builder.Entity<IdentityRoleClaim<string>>()
                .ToTable("RoleClaims", "Security");

        }
    }
}
