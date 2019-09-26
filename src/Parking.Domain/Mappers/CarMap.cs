using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Parking.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Domain.Mappers
{
    public class CarMap : IEntityTypeConfiguration<CarDto>
    {
        public void Configure(EntityTypeBuilder<CarDto> builder)
        {
            builder.ToTable("Car");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CarPlate).IsRequired().HasMaxLength(8).HasColumnType("varchar(8)");
            builder.Property(x => x.YearModel).IsRequired().HasMaxLength(200).HasColumnType("varchar(100)");
            builder.Property(x => x.Color).IsRequired().HasMaxLength(50).HasColumnType("varchar(50)");
        }
    }
}