using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TuklasTalinoService.Users;

namespace TuklasTalinoService
{
    public class TuklasTalinoIdentityDbContext: IdentityDbContext<ApplicationUser>
    {
        private readonly string _connectionString;
        public TuklasTalinoIdentityDbContext(DbContextOptions<TuklasTalinoIdentityDbContext> options, IConfiguration configuration)
        : base(options)
        {
            _connectionString = configuration.GetConnectionString("Postgres") ?? "";
        }

        public DbSet<ApplicationUser>? ApplicationUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder
                .UseNpgsql(_connectionString)
                .UseSnakeCaseNamingConvention();
    }
}
