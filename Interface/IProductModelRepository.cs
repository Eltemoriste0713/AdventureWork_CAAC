using AdventureWork_CAAC.Model;

namespace AdventureWork_CAAC.Interface
{
    public interface IProductModelRepository
    {
        Task<IEnumerable<ProductModel>> GetProductModelAsync();
    }
}
