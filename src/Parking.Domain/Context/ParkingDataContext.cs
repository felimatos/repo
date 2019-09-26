using Microsoft.EntityFrameworkCore;
using Parking.Domain.Mappers;
using Parking.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Domain.Context
{
    public class ParkingDataContext : DbContext
    {
        public DbSet<Parking> Parking { get; set; }
        public DbSet<CarDto> Car { get; set; }
        public DbSet<ReservationDto> Reservation { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=localhost,1433;Database=parking.database;User ID=sa;Password=cm@123456789;");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AgreementMap());
            builder.ApplyConfiguration(new AssociateMap());
            builder.ApplyConfiguration(new CarMap());
            builder.ApplyConfiguration(new CustomerMap());
            builder.ApplyConfiguration(new ParkingMap());
            builder.ApplyConfiguration(new RateMap());
            builder.ApplyConfiguration(new ReservationMap());
        }
    }
}
