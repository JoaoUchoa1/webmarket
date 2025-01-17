﻿using api_webmarket.Domain.Models;
using api_webmarket.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_webmarket.Persistence.Repositories
{
    public class PurchaseRepository : BaseRepository, IPurchaseRepository
    {
        public PurchaseRepository(AppDBCContext context) : base(context)
        { 
            
        }

        public async Task<IEnumerable<Purchase>> ListAsync()
        {
            return await _context.Purchases.ToListAsync();
        }

        public async Task AddAsync(Purchase purchase)
        {
            await _context.Purchases.AddAsync(purchase);
        }

        public async Task<Purchase> FindByIdAsync(int id)
        {
            return await _context.Purchases.FindAsync(id);
        }

        public void Update(Purchase purchase)
        {
            _context.Purchases.Update(purchase);
        }

        public void Delete(Purchase purchase)
        {
            _context.Purchases.Remove(purchase);
        }
    }
}
