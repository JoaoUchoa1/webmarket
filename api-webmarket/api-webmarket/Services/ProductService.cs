using api_webmarket.Communication;
using api_webmarket.Domain.Models;
using api_webmarket.Domain.Repositories;
using api_webmarket.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_webmarket.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IProductRepository productRepository, IUnitOfWork unitOfWork) 
        {
            _productRepository = productRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Product>> ListAsync()
        {
            return await _productRepository.ListAsync();
        }

        public async Task<SaveProductResponse> SaveAsync(Product product)
        {
            try
            {
                await _productRepository.AddAsync(product);
                await _unitOfWork.CompleteAsync();

                return new SaveProductResponse(product);
            }
            catch (Exception ex)
            {
                return new SaveProductResponse($"An error occurred when saving the Product: { ex.Message}");
            }
        }
    }
}
