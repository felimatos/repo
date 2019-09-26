using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Domain.Mappers
{
    public class RateMap : IEntityTypeConfiguration<Rate>
    {
        public void Configure(EntityTypeBuilder<Rate> builder)
        {
            builder.ToTable("Rate");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(200).HasColumnType("varchar(200)");
            builder.Property(x => x.DayValue).IsRequired();
            builder.Property(x => x.NightStayValue);
            builder.Property(x => x.NightStayFracValue);
        }
    }
}