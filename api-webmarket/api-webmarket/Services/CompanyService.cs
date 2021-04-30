using api_webmarket.Domain.Models;
using api_webmarket.Domain.Repositories;
using api_webmarket.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_webmarket.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyService(ICompanyRepository companyRepository) 
        {
            _companyRepository = companyRepository;
        }

        public async Task<IEnumerable<Company>> ListAsync()
        {
            return await _companyRepository.ListAsync();
        }
    }
}
