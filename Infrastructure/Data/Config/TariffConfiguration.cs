using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Config
{
    public class TariffConfiguration : IEntityTypeConfiguration<Tariff>
    {
        public void Configure(EntityTypeBuilder<Tariff> builder)
        {
            builder.Property(t=>t.Id).IsRequired();
            builder.Property(t=>t.Name).IsRequired().HasMaxLength(100);
            builder.Property(t=>t.Description).HasMaxLength(180);
            builder.Property(t=>t.Price).HasColumnType("decimal(18,2)");
            //builder.Property(t=>t.PictureUrl);
            builder.HasOne(r=>r.Resolution).WithMany().HasForeignKey(t=>t.ResolutionId);
            builder.HasOne(p=>p.Period).WithMany().HasForeignKey(t=>t.PeriodId);
        }
    }
}
 