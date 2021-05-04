using api_webmarket.Communication;
using api_webmarket.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_webmarket.Domain.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> ListAsync();
        Task<SaveProductResponse> SaveAsync(Product product);
    }
}
