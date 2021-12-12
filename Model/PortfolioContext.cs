using Microsoft.EntityFrameworkCore;

namespace Portfolio
{
    public class PortfolioContext : DbContext
    {
        public PortfolioContext(
            DbContextOptions options) : base(options)
        {
        }

        public DbSet<Project> Projects { get; set; }
    }
}