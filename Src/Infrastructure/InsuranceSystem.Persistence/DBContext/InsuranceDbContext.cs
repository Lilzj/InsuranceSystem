using InsuranceSystem.Domain;
using Microsoft.EntityFrameworkCore;

namespace InsuranceSystem.Persistence.DBContext
{
    public class InsuranceDbContext : DbContext
    {
        public InsuranceDbContext(DbContextOptions<InsuranceDbContext> options) : base(options) { }
        public DbSet<Claim> Claims { get; set; }  
        public DbSet<Policy> Policies { get; set; }
        public DbSet<Expense> Expenses { get; set; }
    }
}
