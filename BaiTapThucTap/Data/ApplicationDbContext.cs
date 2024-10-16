using BaiTapThucTap.Models;
using Microsoft.EntityFrameworkCore;

namespace BaiTapThucTap.Data
{
	public class ApplicationDbContext : DbContext
	{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

		public DbSet<CalculationUnit> CalculationUnits { get; set; }
		public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CalculationUnit>().HasIndex(i => i.CalculationUnitName).IsUnique();
            modelBuilder.Entity<ProductCategory>().HasIndex(i => i.ProductCategoryName).IsUnique();
            modelBuilder.Entity<Supplier>().HasIndex(i => i.SupplierName).IsUnique();
        }
    }
}
