using BaiTapThucTap.Models;
using Microsoft.EntityFrameworkCore;

namespace BaiTapThucTap.Data
{
	public class ApplicationDbContext : DbContext
	{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

		public DbSet<CalculationUnit> CalculationUnits { get; set; }
		public DbSet<ProductCategory> ProductCategories { get; set; }
    }
}
