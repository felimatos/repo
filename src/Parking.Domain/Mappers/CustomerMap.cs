using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Domain.Mappers
{
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Address).IsRequired().HasMaxLength(7).HasColumnType("varchar(200)");
            builder.Property(x => x.Description).IsRequired().HasMaxLength(200).HasColumnType("varchar(100)");
            builder.Property(x => x.Document).IsRequired().HasMaxLength(50).HasColumnType("varchar(50)");
            builder.Property(x => x.Phone).IsRequired().HasMaxLength(50).HasColumnType("varchar(50)");
        }
    }
}