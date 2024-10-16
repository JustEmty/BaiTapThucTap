using BaiTapThucTap.Data;
using BaiTapThucTap.Models;
using BaiTapThucTap.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace BaiTapThucTap.Repositories
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public SupplierRepository(ApplicationDbContext applicationDbContext) =>
            this.applicationDbContext = applicationDbContext;

        public async Task CreateAsync(Supplier supplier)
        {
            await applicationDbContext.Suppliers.AddAsync(supplier);
            await applicationDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Supplier supplier)
        {
            applicationDbContext.Suppliers.Remove(supplier);
            await applicationDbContext.SaveChangesAsync();
        }

        public async Task<List<Supplier>> GetAllAsync()
        {
            return await applicationDbContext.Suppliers.ToListAsync();
        }

        public async Task<Supplier?> GetAsync(int id)
        {
            return await applicationDbContext.Suppliers.Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public async Task UpdateAsync(Supplier supplier)
        {
            applicationDbContext.Suppliers.Update(supplier);
            await applicationDbContext.SaveChangesAsync();
        }
    }
}
