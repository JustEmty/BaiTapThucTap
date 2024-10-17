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
        public DbSet<Storage> Storages { get; set; }
        public DbSet<StorageUser> StorageUsers { get; set; }
        public DbSet<EntryStorageForm> EntryStorageForms { get; set; }
        public DbSet<EntryStorageFormRawData> EntryStorageFormRawDatas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CalculationUnit>().HasIndex(i => i.CalculationUnitName).IsUnique();
            modelBuilder.Entity<ProductCategory>().HasIndex(i => i.ProductCategoryName).IsUnique();
            modelBuilder.Entity<Supplier>().HasIndex(i => i.SupplierName).IsUnique();
            modelBuilder.Entity<Storage>().HasIndex(i => i.StorageName).IsUnique();
            modelBuilder.Entity<StorageUser>().HasIndex(i => i.LoginCode).IsUnique();
            modelBuilder.Entity<StorageUser>().HasIndex(i => i.StorageId).IsUnique();
            modelBuilder.Entity<EntryStorageForm>().HasIndex(i => i.EntryStorageFormId).IsUnique();
        }
    }
}
