using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Domain.Mappers
{
    public class ParkingMap : IEntityTypeConfiguration<Parking>
    {
        public void Configure(EntityTypeBuilder<Parking> builder)
        {
            builder.ToTable("Parking");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(200).HasColumnType("varchar(200)");
            builder.Property(x => x.Document).IsRequired().HasMaxLength(50).HasColumnType("varchar(50)");
            builder.Property(x => x.Address).HasMaxLength(250).HasColumnType("varchar(250)");
            builder.Property(x => x.Phone).HasMaxLength(50).HasColumnType("varchar(50)");
        }        
    }
}
