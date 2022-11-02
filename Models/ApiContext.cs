using Microsoft.EntityFrameworkCore;

namespace dotnet_ng_api
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Server> Servers { get; set; }
    }
}