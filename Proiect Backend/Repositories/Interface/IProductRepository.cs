using Proiect_Backend.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Proiect_Backend.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDto>> GetAllProductsAsync();
        Task<ProductDto> GetProductByIdAsync(int productId);
        Task<ProductDto> CreateProductAsync(CreateProductDto createProductDto);
        Task UpdateProductAsync(int productId, UpdateProductDto updateProductDto);
        Task DeleteProductAsync(int productId);
    }
}
