namespace Identity.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<IdentityUser> (options)
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityUser>()
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
