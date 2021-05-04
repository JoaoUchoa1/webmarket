using api_webmarket.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_webmarket.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDBCContext _context;
        public UnitOfWork(AppDBCContext context) 
        {
            _context = context;
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
