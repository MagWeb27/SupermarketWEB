using Microsoft.EntityFrameworkCore;
using SupermarketWeb.Models;

namespace SupermarketWeb.Data
{
    public class SupermarketContext : DbContext
    {
        public SupermarketContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<PayMode> PayModes { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Detail> Details { get; set; }
    }
}
