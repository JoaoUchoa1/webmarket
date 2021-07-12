using api_webmarket.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_webmarket.Domain.Repositories
{
    public interface ICompanyRepository
    {
        Task<IEnumerable<Company>> ListAsync();

        Task AddAsync(Company company);
        Task<Company> FindByIdAsync(int id);
        void Update(Company company);
        void Delete(Company company);
    }
}
