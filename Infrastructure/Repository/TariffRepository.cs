using Core.Entities;
using Infrastructure.Data;
using Infrastructure.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class TariffRepository : ITariffRepository
    {
        private readonly StoreContext _context;
        public TariffRepository(StoreContext context)
        {
            _context = context;
        }
        public async Task<IReadOnlyList<Tariff>> GetTariffsAsync()
        {
            return await _context.Tariffs.ToListAsync();
            
        }

        public async Task<Tariff> GetTariffByIdAsync(int id)
        {
            return await _context.Tariffs.FindAsync(id);
        }

        public async Task<IReadOnlyList<Resolution>> GetResolutionsAsync()
        {
            return await _context.Resolutions.ToListAsync();
        }

        public async Task<IReadOnlyList<Period>> GetPeriodsAsync()
        {
            return await _context.Periods.ToListAsync();
        }
    }
}
