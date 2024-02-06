using Proiect_Backend.Data;
using Proiect_Backend.DTO;
using Proiect_Backend.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Proiect_Backend.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ProductDto>> GetAllProductsAsync()
        {
            return await _context.Products
                .Select(product => new ProductDto
                {
                    Name = product.Name,
                    Price = product.Price,
                    CategoryId = product.CategoryId
                })
                .ToListAsync();
        }

        public async Task<ProductDto> CreateProductAsync(CreateProductDto createProductDto)
        {
            var product = new Product
            {
                Name = createProductDto.Name,
                Price = createProductDto.Price,
                CategoryId = createProductDto.CategoryId
            };

            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return new ProductDto { Name = product.Name, Price = product.Price, CategoryId = product.CategoryId };
        }

        public async Task UpdateProductAsync(int productId, UpdateProductDto updateProductDto)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product != null)
            {
                product.Name = updateProductDto.Name;
                product.Price = updateProductDto.Price;
                product.CategoryId = updateProductDto.CategoryId;

                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteProductAsync(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product != null)
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }
        }

        public Task<ProductDto> GetProductByIdAsync(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
