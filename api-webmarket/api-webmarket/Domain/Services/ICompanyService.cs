using api_webmarket.Communication;
using api_webmarket.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_webmarket.Domain.Services
{
    public interface ICompanyService
    {
        Task<IEnumerable<Company>> ListAsync();
        Task<SaveCompanyResponse> SaveAsync(Company company);
    }
}
