using AdventureWork_CAAC.Interface;
using AdventureWork_CAAC.Model;
using Microsoft.EntityFrameworkCore;

namespace AdventureWork_CAAC.Data
{
    public class ProductModelRepository : IProductModelRepository
    {
        private readonly AppDbContext _context;

        public ProductModelRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<ProductModel>> GetProductModelAsync() => await _context.ProductModel.Take(100).ToListAsync();

    }
}
