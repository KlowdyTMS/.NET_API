using Microsoft.EntityFrameworkCore;
using PrimeiraAPI.Models.Employees;

namespace Infra.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Employees> Employees { get; set; }
    }
}
