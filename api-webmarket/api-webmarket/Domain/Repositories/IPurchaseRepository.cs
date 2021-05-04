using api_webmarket.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_webmarket.Domain.Repositories
{
    public interface IPurchaseRepository
    {
        Task<IEnumerable<Purchase>> ListAsync();
        Task AddAsync(Purchase purchase);
    }
}
