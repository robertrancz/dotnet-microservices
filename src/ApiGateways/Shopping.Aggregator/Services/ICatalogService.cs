using Shopping.Aggregator.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shopping.Aggregator.Services
{
    public interface ICatalogService
    {
        Task<IEnumerable<CatalogModel>> GetCatalogAsync();
        Task<IEnumerable<CatalogModel>> GetCatalogByCategoryAsync(string category);
        Task<CatalogModel> GetCatalogAsync(string id);
    }
}
