﻿using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }
        public DbSet<Tariff> Tariffs { get; set; }
        public DbSet<Resolution> Resolutions { get; set; }
        public DbSet<Period> Periods { get; set; }
    }
}
 