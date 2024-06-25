using DotNetApi.Domain.Customers;
using Microsoft.EntityFrameworkCore;

namespace DotNetApi.Infrastructure
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Customer> Customer { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Server=localhost; Port=5432; Database=structure; User Id=postgres; Password=cs305;");
    }
}
