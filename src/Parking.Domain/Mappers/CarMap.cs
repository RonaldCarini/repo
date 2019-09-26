using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Domain.Mappers
{
    public class CarMap : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("Car");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.LicensePlate).IsRequired().HasMaxLength(20).HasColumnType("varchar(20)");
            builder.Property(x => x.Model).IsRequired().HasMaxLength(100).HasColumnType("varchar(100)");
            builder.Property(x => x.Year);
            builder.Property(x => x.Color).HasMaxLength(50).HasColumnType("varchar(50)");
        }
    }
}
