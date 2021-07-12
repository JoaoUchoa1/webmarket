using api_webmarket.Domain.Models;
using api_webmarket.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_webmarket.Persistence.Repositories
{
    public class CompanyRepository : BaseRepository, ICompanyRepository
    {

        public CompanyRepository(AppDBCContext context) : base(context) 
        { 
            
        }

        public async Task<IEnumerable<Company>> ListAsync()
        {
            return await _context.Companies.ToListAsync();
        }

        public async Task AddAsync(Company company) 
        {
            await _context.Companies.AddAsync(company);
        }

        public async Task<Company> FindByIdAsync(int id)
        {
            return await _context.Companies.FindAsync(id);
        }

        public void Update(Company company)
        {
            _context.Companies.Update(company);
        }

        public void Delete(Company company)
        {
            _context.Companies.Remove(company);
        }
    }
}
