using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Product?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<Product> CreateAsync(CreateProductDto dto)
        {
            var product = new Product
            {
                ProductName = dto.ProductName,
                CreatedBy = "Admin",
                CreatedOn = DateTime.Now
            };

            await _repository.AddAsync(product);

            await _repository.SaveChangesAsync();

            return product;
        }

        public async Task UpdateAsync(int id, CreateProductDto dto)
        {
            var product = await _repository.GetByIdAsync(id);

            if (product == null)
                return;

            product.ProductName = dto.ProductName;

            product.ModifiedBy = "Admin";

            product.ModifiedOn = DateTime.Now;

            _repository.Update(product);

            await _repository.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var product = await _repository.GetByIdAsync(id);

            if (product == null)
                return;

            _repository.Delete(product);

            await _repository.SaveChangesAsync();
        }
    }
}
