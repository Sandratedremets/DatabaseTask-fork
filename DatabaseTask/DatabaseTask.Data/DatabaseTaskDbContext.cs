using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<AccessLevel> AccessLevel { get; set; }
        public DbSet<Children> Children { get; set; }
        public DbSet<HealthCheck> HealthCheck { get; set; }
        public DbSet<JobTenure> JobTenure { get; set; }
        public DbSet<Position> Position { get; set; }
        public DbSet<Request> Request { get; set; }
        public DbSet<SickLeave> SickLeave { get; set; }
        public DbSet<Suggestion_hints> Suggestions_hints { get; set; }
        public DbSet<Vacation> Vacation { get; set; }
        public DbSet<Loaning> Loaning { get; set; }
        public DbSet<LoanableItems> LoanableItem { get; set; }
    }
}
