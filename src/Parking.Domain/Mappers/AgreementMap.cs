using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Domain.Mappers
{
    public class AgreementMap : IEntityTypeConfiguration<Agreement>
    {
        public void Configure(EntityTypeBuilder<Agreement> builder)
        {
            builder.ToTable("Agreement");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(200).HasColumnType("varchar(200)");
            builder.Property(x => x.DiscountValue).IsRequired().HasColumnType("money");
            builder.Property(x => x.PercentValue).IsRequired();
        }
    }
}