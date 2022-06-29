using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.IRepository
{
    public interface ITariffRepository
    {
        Task<Tariff> GetTariffByIdAsync(int id);
        Task<IReadOnlyList<Tariff>> GetTariffAsync();
    }
}
