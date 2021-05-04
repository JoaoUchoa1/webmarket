using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_webmarket.Persistence.Repositories
{
    public class BaseRepository
    {
        protected readonly AppDBCContext _context;

        public BaseRepository(AppDBCContext context) 
        {
            _context = context;
        }
    }
}
